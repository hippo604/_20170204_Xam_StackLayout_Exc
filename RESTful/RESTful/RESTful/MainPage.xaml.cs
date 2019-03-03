using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace RESTful
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }

    public partial class MainPage : ContentPage
    {

        private const string Url = "https://jsonplaceholder.typicode.com/posts";

        //Need System.Net.Http for HttpClient
        private HttpClient _client = new HttpClient();
        private ObservableCollection<Post> _posts;

        public MainPage()
        {
            InitializeComponent();
        }

        //as always, await needs async
        protected override async void OnAppearing()
        {
            var content = await _client.GetStringAsync(Url);

            //Deserialize w JsonConvert. Need Newtonsoft.Json for this.
            //from the NewtonSoft docs: 
            //DeserializeObject<T>(String)	>> Deserializes the JSON to the specified .NET type.
            var posts = JsonConvert.DeserializeObject<List<Post>>(content);

            _posts = new ObservableCollection<Post>(posts);
            postsListView.ItemsSource = _posts;

            base.OnAppearing();
        }

        async void OnAdd(object sender, System.EventArgs e)
        {
            var post = new Post { Title = "Title" + DateTime.Now.Ticks };

            var content = JsonConvert.SerializeObject(post);
            await _client.PostAsync(Url, new StringContent(content));

            _posts.Insert(0, post);
        }

        async void OnUpdate(object sender, System.EventArgs e)
        {
            //For this to work you need INotifyPropertyChanged
            var post = _posts[0];
            post.Title += "UPDATED";

            //This time it's a put, and you specify the ID#
            var content = JsonConvert.SerializeObject(post);
            await _client.PutAsync(Url + "/" + post.Id, new StringContent(content));
        }

        async void OnDelete(object sender, System.EventArgs e)
        {
            var post = _posts[0];

            await _client.DeleteAsync(Url + "/" + post.Id);
            _posts.Remove(post);
        }
    }
}
