using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NavigationExercise.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavigationExercise
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProfilePage : ContentPage
	{
		public ProfilePage (User user)
		{
			InitializeComponent ();

            if (user == null)
                throw new ArgumentNullException();

            //Binding context of the ...page...?
            BindingContext = user;
        }
	}
}