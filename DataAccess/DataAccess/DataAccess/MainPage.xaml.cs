using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DataAccess
{
    public partial class MainPage : ContentPage
    {
        private SQLiteAsyncConnection _connection;
        private ObservableCollection<Recipe> _recipes;


        public class Recipe : INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler PropertyChanged;

            //Decorated with attributes for SQLite DB
            [PrimaryKey, AutoIncrement]
            public int Id { get; set; }

            public string _name;

            [MaxLength(255)]
            public string Name
            {
                get { return _name; }
                set
                {
                    if (_name == value)
                        return;
                    _name = value;

                    //used to be "OnPropertyChanged(nameof(Name));"
                    OnPropertyChanged();
                }
            }

            //CallerMemberName is an attribute from System.Runtime.CompilerServices
            //Allows us to get rid of the OnPropertyChanged argument; it now
            //grabs the CallerName attribute that is calling the function (Name)
            private void OnPropertyChanged([CallerMemberName] string propertyName = null)
            {
                //Used to be if (PropertyChanged != null)..PropertyChanged(this...
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public MainPage()
        {
            InitializeComponent();

            //This connection isn't like opening/closing a connection in ADO.net.
            //It has methods for +ing, updating, -ing, & getting objects from the DB.
            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();

            //As a general best practice, this constructor should be lighweight; it 
            //shouldn't touch the file system, go in the DB, or access something on the network
        }

        protected override async void OnAppearing()
        {
            //Creates table if it doesn't exist
            await _connection.CreateTableAsync<Recipe>();

            //Add recipes to 
            var recipes = await _connection.Table<Recipe>().ToListAsync();
            _recipes = new ObservableCollection<Recipe>(recipes);
            recipesListView.ItemsSource = _recipes;

            base.OnAppearing();
        }

        async void OnAdd(object sender, System.EventArgs e)
        {
            var recipe = new Recipe { Name = "Recipe_ " + DateTime.Now.Ticks };
            await _connection.InsertAsync(recipe);
            _recipes.Add(recipe);
        }

        async void OnUpdate(object sender, System.EventArgs e)
        {
            //This updates the 1st recipe, not the selected one
            var recipe = _recipes[0];
            recipe.Name += " UPDATED_";
            await _connection.UpdateAsync(recipe);
        }

        async void OnDelete(object sender, System.EventArgs e)
        {
            //This deletes the 1st recipe, not the selected one
            var recipe = _recipes[0];
            await _connection.DeleteAsync(recipe);
            _recipes.Remove(recipe);
        }
    }
}
