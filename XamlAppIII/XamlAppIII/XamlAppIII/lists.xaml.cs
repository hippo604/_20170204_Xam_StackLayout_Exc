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



        public Lists()
        {
            InitializeComponent();

            listView.ItemsSource = new List<Contact>
            {
                new Contact { Name = "Mosh", Status = "abc", ImageUrl = "https://via.placeholder.com/100x100/ff7f7f/333333?text=Mosh"},
                new Contact { Name = "John", Status = "def", ImageUrl = "https://via.placeholder.com/100x100/ff7f77/333333?text=John"}
            };
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

            DisplayAlert("Selected", contact.Name, "OK");
        }
    }
}