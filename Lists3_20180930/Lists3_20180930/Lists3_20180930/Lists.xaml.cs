using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lists3_20180930
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Lists : ContentPage
	{
		public Lists ()
		{
			InitializeComponent ();
            var names = new List<string>
            {
                "Mosh",
                "John",
                "Bob"
            };

            listView.ItemsSource = names;
		}
	}
}