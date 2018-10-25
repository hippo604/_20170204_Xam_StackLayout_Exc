using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ListExercise.Models;
using System.Collections.ObjectModel;

namespace ListExercise
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SearchPage : ContentPage
	{
		public SearchPage ()
		{
			InitializeComponent ();
            var searches = new ObservableCollection<SearchGroup2>
            {
                new SearchGroup2("Recent Searches"){
                    new Search {Id="1", Location="Taipei 台北", CheckIn=new DateTime(2018, 04, 14), CheckOut = new DateTime(2018, 04, 15) },
                    new Search {Id="2", Location="Naha 那覇", CheckIn=new DateTime(2018, 04, 14), CheckOut = new DateTime(2018, 04, 15) },
                    new Search {Id="3", Location="Kumamoto 熊本", CheckIn=new DateTime(2018, 06, 14), CheckOut = new DateTime(2018, 06, 15) },
                    new Search {Id="4", Location="Tokyo 東京", CheckIn=new DateTime(2018, 05, 14), CheckOut = new DateTime(2018, 05, 15) }
                }
            };

            listView.ItemsSource = searches;
		}
	}
}