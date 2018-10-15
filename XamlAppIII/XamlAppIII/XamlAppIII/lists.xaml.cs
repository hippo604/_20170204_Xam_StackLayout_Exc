using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamlAppIII.Models;
using System.Collections.ObjectModel;

namespace XamlAppIII
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Lists : ContentPage
	{
        //Most collections are iEnumerable, which is a lightweight
        //interface (can't remove)
        private ObservableCollection<Contact> _contacts;

        private void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //var contact = e.Item as contact;
            var contact = e.Item as Contact;
            DisplayAlert("Tapped", contact.Name, "OK");

        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var contact = e.SelectedItem as Contact;

            //DisplayAlert("Selected", contact.Name, "OK");
        }
               
        //sender is menu item
        void Call_Clicked(object sender, System.EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;

            DisplayAlert("Call", contact.Name, "OK");
        }

        void Delete_Clicked(object sender, System.EventArgs e)
        {
            //2 lines above in 1 line
            var contact = (sender as MenuItem).CommandParameter as Contact;
            _contacts.Remove(contact);
            
        }

        public Lists()
        {
            InitializeComponent();


            //Before ↓　was listView.ItemsSource = new List<Contact>
            //ObsvblCollctn needed for refresh to show deleted contacts
            _contacts = new ObservableCollection<Contact>
            {
                new Contact { Name = "Mosh", Status = "abc", ImageUrl = "https://via.placeholder.com/100x100/ff7f7f/333333?text=Mosh"},
                new Contact { Name = "John", Status = "def", ImageUrl = "https://via.placeholder.com/100x100/ff7f77/333333?text=John"}
            };

            //These changes make contact in list deletable thru the Delete handler
            listView.ItemsSource = _contacts;
        }




    }
}