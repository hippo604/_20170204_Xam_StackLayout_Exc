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
        private IEnumerable<Contact> _contacts;

        //For this exercise contacts were split out in a function
        //_contacts is my awkward workaround to maintain the deletion context choice
        IEnumerable<Contact> GetContacts(string searchText = null)
        {
            _contacts = new List<Contact> {
                new Contact { Name = "Mosh", Status = "abc", ImageUrl = "https://via.placeholder.com/100x100/ff7f7f/333333?text=Mosh"},
                new Contact { Name = "Joe", Status = "def", ImageUrl = "https://via.placeholder.com/100x100/ff7f77/333333?text=Stan"},
                new Contact { Name = "たろう", Status = "def", ImageUrl = "https://via.placeholder.com/100x100/ff7f77/333333?text=Taro"}
            };

            if (String.IsNullOrWhiteSpace(searchText))
                return _contacts;

            return _contacts.Where(c => c.Name.StartsWith(searchText, StringComparison.CurrentCultureIgnoreCase));
        }


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
            //_contacts.Remove(contact);
            
        }

        void Handle_Refreshing(object sender, System.EventArgs e)
        {
            //Using _contacts below prevents the undeletion effect
            listView.ItemsSource = GetContacts();
            listView.EndRefresh();
        }

        void Handle_Textchanged(object sender, TextChangedEventArgs e)
        {
            listView.ItemsSource = GetContacts(e.NewTextValue);
        }

        public Lists()
        {
            InitializeComponent();
            //Change below to reference to function
            listView.ItemsSource = GetContacts();
        }




    }
}