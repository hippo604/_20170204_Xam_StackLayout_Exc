using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ListExercise.Models;

namespace ListExercise
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SearchPage : ContentPage
	{
		public SearchPage ()
		{
			InitializeComponent ();
            var searches = new List<Search>
            {
                new Search {Id="1", Location="Hollywood", CheckIn=new DateTime(2018, 04, 14), CheckOut = new DateTime(2018, 04, 15) },
                new Search {Id="2", Location="Bollywood", CheckIn=new DateTime(2018, 06, 14), CheckOut = new DateTime(2018, 06, 15) },
                new Search {Id="3", Location="Tokyo", CheckIn=new DateTime(2018, 05, 14), CheckOut = new DateTime(2018, 05, 15) }


            };

            listView.ItemsSource = searches;
		}
	}
}