using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class IntroductionPage : ContentPage
	{
		public IntroductionPage ()
		{
			InitializeComponent ();
		}

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
            //Asynchronously removes the top Page from the navigation stack.
        }

        protected override bool OnBackButtonPressed()
        {
            //If you want the default behaviour with the back button
            //return base.OnBackButtonPressed();

            //If you want to block the behaviour of the back button
            //You need to do this for a modal page
            return true;
        }
    }
}