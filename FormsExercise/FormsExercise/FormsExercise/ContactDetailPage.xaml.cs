using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FormsExercise
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactDetailPage : ContentPage
	{
		public ContactDetailPage ()
		{
			InitializeComponent ();
		}

        public TableView ContactDetails { get { return tableView; } }    
        public Button Button { get { return buttonSave; } set { } }

        public EntryCell FirstName { get { return firstName; } set { } }
        public EntryCell LastName { get { return lastName; } set { } }
        public EntryCell Phone { get { return phone; } set { } }
        public EntryCell Email { get { return email; } set { } }

        public SwitchCell IsBlocked { get { return isblocked; } set { } }


    }
}