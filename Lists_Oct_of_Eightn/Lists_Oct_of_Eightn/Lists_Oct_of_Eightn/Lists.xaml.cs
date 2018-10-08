using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Lists_Oct_of_Eightn.Models;
using System.Collections.ObjectModel;
using Models;

namespace Lists_Oct_of_Eightn
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Lists : ContentPage
	{
        public Lists()
        {
            InitializeComponent();

            listView.ItemsSource = new List<ContactGroup>
            {
                new ContactGroup("M", "M"){
                    new Contact{Name="Mosh", ImageUrl="https://via.placeholder.com/100x100/ff7f7f/333333?text=abc"}
                },
                new ContactGroup("J", "J"){
                    new Contact{Name="John", ImageUrl="https://via.placeholder.com/100x100/ff7f7f/333333?text=jkl"}
                }
            };



        }
	}
}