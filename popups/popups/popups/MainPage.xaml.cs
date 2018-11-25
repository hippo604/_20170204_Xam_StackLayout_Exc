using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace popups
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            //Destruction seems to be red in iOS but normal in Android
            //Can pass null ("") for Destruction as below
            //for the actions at the end, you can also pass a string array
            var response = await DisplayActionSheet("Title", "Cancel", "", "漢字ブックに登録", "詳細変更", "常用漢字一覧に移る");
            await DisplayAlert("Your Response", "Your response was " + response, "Cancel");
        }
    }
}
