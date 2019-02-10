using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using FormsExercise.Classes;
using FormsExercise;
using System.Collections.ObjectModel;


namespace FormsExercise
{
    public partial class MainPage : ContentPage
    {
        //Originally had this as a List, but had problems with Delete & Add didn't work
        private ObservableCollection<Contact> _contacts = new ObservableCollection<Contact>
            {
                new Contact(1, "Smith", "Joe", 123456),
                new Contact(2, "Tanaka", "Biff", 323456)
            };

        public MainPage()
        {
            InitializeComponent();
            listView.ItemsSource = _contacts;
        }

        async void Button_Add_Clicked(object sender, EventArgs e)
        {
            var page = new ContactDetailPage();
            var contact = new Contact(_contacts.Count+1, "...", "...", 1234);

            page.FirstName.Text = contact.Firstname;
            page.LastName.Text = contact.Lastname;
            page.Phone.Text = contact.Phonenumber.ToString();
            page.Email.Text = contact.Email;
            page.IsBlocked.On = contact.IsBlocked;
            

            await Navigation.PushModalAsync(page);

            page.Button.Clicked += (source, args) =>
            {
                contact.Firstname = page.FirstName.Text;
                contact.Lastname = page.LastName.Text;
                contact.Phonenumber = Convert.ToInt32(page.Phone.Text);
                contact.Email = page.Email.Text;
                contact.IsBlocked = page.IsBlocked.On;

                if (String.IsNullOrWhiteSpace(contact.FullName))
                {
                    DisplayAlert("Error", "Please enter a name.", "OK");
                }

                _contacts.Add(contact);
            };
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            //pretty much copied from before
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;
            _contacts.Remove(contact);
        }

        async void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var page = new ContactDetailPage();
            var contact = e.SelectedItem as Contact;

            page.FirstName.Text = contact.Firstname;
            page.LastName.Text = contact.Lastname;
            page.Phone.Text = contact.Phonenumber.ToString();
            page.Email.Text = contact.Email;
            page.IsBlocked.On = contact.IsBlocked;

            await Navigation.PushModalAsync(page);

            page.Button.Clicked += (source, args) =>
            {
                contact.Firstname = page.FirstName.Text;
                contact.Lastname = page.LastName.Text;
                contact.Phonenumber = Convert.ToInt32(page.Phone.Text);
                contact.Email = page.Email.Text;
                contact.IsBlocked = page.IsBlocked.On;

                if (String.IsNullOrWhiteSpace(contact.FullName))
                {
                    DisplayAlert("Error", "Please enter a name.", "OK");
                }
            };
        }
    }
}
