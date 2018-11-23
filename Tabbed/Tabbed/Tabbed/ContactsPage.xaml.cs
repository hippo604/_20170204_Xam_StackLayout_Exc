using Tabbed.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tabbed
{
    //All the same as before
    //MasterDetailPage, not a ContentPage
    public partial class ContactsPage : MasterDetailPage
    {
        void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {            
            //get currently selected contact
            var contact = e.SelectedItem as Contact;

            //NavigationPage is needed for back functionality
            Detail = new NavigationPage(new ContactDetailPage(contact));

            //Decide if the master's presented. False for iPhone.
            IsPresented = false; 

            //No more nulling needed

        }

        public ContactsPage()
        {
            InitializeComponent();

            listView.ItemsSource = new List<Contact> {
                new Contact { Name = "Mosh", ImageUrl = "http://lorempixel.com/100/100/people/1" },
                new Contact { Name = "John", ImageUrl = "http://lorempixel.com/100/100/people/2", Status = "Hey, let's talk! AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA AAAAAAAAAAAAAAAAAAAAAAAAAA AAAAAAAAAAAAAAA" }
            };
        }
    }
}