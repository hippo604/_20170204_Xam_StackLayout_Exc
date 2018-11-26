using NavigationExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavigationExercise
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListPage : ContentPage
	{
        //Not sure if IRL activity service would be here
        ActivityService activityService = new ActivityService();
        UserService userService = new UserService();
        
        public ListPage ()
		{
			InitializeComponent ();
            listView.ItemsSource = activityService.GetActivities();
        }

        async void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //see 2018/11/17 for deselecting contact on user return
            if (e.SelectedItem == null)
                return;

            //get currently selected contact
            Activity activity = e.SelectedItem as Activity;
            User user = userService.GetUser(activity.UserId);

            await Navigation.PushAsync(new ProfilePage(user));

            //see 2018/11/17 for deselecting contact on user return
            listView.SelectedItem = null;
        }
    }
}