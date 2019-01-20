using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FormsSettingPages.Extensions
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DateCell2 : ViewCell
	{
        //"Bindable インフラ"; all this is done for stock classes. For instance,
        //...the Text property (Label class) references the backing field "TextProperty"
        public static readonly BindableProperty LabelProperty =
            BindableProperty.Create("Label", typeof(string), typeof(DateCell2));

        public string Label
        {
            get {return (string)GetValue(LabelProperty);}
            set { SetValue(LabelProperty, value); }
        }

        public DateCell2 ()
		{
			InitializeComponent ();

            //We've used BindingContext before in the ContactDetailsPage
            BindingContext = this;
		}
	}
}