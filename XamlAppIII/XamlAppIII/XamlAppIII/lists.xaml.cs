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
        private ObservableCollection<Contact> _contacts;

        //For this exercise contacts were split out in a function
        //_contacts is my awkward workaround to maintain the deletion context choice
        ObservableCollection<Contact> GetContacts()
        {
            _contacts = new ObservableCollection<Contact> {
                new Contact { Name = "Mosh", Status = "abc", ImageUrl = "https://via.placeholder.com/100x100/ff7f7f/333333?text=Mosh"},
                new Contact { Name = "John", Status = "def", ImageUrl = "https://via.placeholder.com/100x100/ff7f77/333333?text=John"},
                new Contact { Name = "Stan", Status = "def", ImageUrl = "https://via.placeholder.com/100x100/ff7f77/333333?text=Stan"},
                new Contact { Name = "Joe", Status = "def", ImageUrl = "https://via.placeholder.com/100x100/ff7f77/333333?text=Stan"}

            };
            return _contacts;
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
            _contacts.Remove(contact);
            
        }

        void Handle_Refreshing(object sender, System.EventArgs e)
        {
            //Using _contacts below prevents the undeletion effect
            listView.ItemsSource = GetContacts();
            listView.EndRefresh();
        }

        public Lists()
        {
            InitializeComponent();
            //Change below to reference to function
            listView.ItemsSource = GetContacts();
        }




    }
}