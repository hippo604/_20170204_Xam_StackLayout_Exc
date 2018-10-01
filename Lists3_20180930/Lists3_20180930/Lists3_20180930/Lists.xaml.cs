using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Lists3_20180930.Models;
using System.Collections.ObjectModel;



namespace Lists3_20180930
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Lists : ContentPage
	{
        public Lists()
        {
            InitializeComponent();

            listView.ItemsSource  = new string[]
                {
                  "mono",
                  "monodroid",
                  "monotouch",
                  "monorail",
                  "monodevelop",
                  "monotone",
                  "monopoly",
                  "monomodal",
                  "mononucleosis"
                };



        }
	}
}