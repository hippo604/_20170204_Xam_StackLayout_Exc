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
	public partial class WelcomePage : ContentPage
	{
		public WelcomePage ()
		{
			InitializeComponent ();
		}

        async void Button_Clicked(object sender, EventArgs e)
        {
            //Each content page has a Navigation property (of type INavigation)
            //See 2018/1/6 for more details on async/await
            await Navigation.PushModalAsync(new IntroductionPage());
        }
    }
}