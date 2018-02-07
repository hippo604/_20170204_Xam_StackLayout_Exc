using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoreLayouts
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GridWithCode : ContentPage
	{
		public GridWithCode ()
		{
			InitializeComponent ();

            var grid = new Grid
            {
                RowSpacing = 20,
                ColumnSpacing = 40
            };
            var label = new Label { Text = "Label1" };
            grid.Children.Add(label, 0, 0);
            Grid.SetRowSpan(label, 2);

        }
    }
}