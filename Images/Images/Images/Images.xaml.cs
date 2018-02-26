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
	public partial class Images : ContentPage
	{
		public Images ()
		{
			InitializeComponent ();

            // image.Source returns an ImageSource 
            // (abstract class, which you can't instantiate. See 20171109-10)

            //Method 1
            var imageSource1 = (UriImageSource) ImageSource.FromUri(new Uri("http://lorempixel.com/1920/1080/sports/7"));

            //Method 2--cleaner
            var imageSource2 = new UriImageSource { Uri=new Uri("http://lorempixel.com/1920/1080/sports/3") };

            //In XAML image is cached for 24 hours. You can control caching here.
            imageSource2.CachingEnabled = false;
            //imageSource1.CacheValidity = TimeSpan.FromHours(1);

            image4.Source = imageSource2;

            //image3.Source = "http://..." will be implicitly converted
            //This is why you can specify a string in XAML
        }
    }
}