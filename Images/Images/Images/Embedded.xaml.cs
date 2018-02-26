using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Images
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Embedded : ContentPage
	{
		public Embedded ()
		{
			InitializeComponent ();
            image.Source = ImageSource.FromFile("car_in_japan.jpg");
            //image.Source = ImageSource.FromResource("Images.Images.two_trees.jpg");
            //doesn't work...
		}
	}
}