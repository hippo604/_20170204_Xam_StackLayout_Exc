using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ListExercise.Models;
using System.Collections.ObjectModel;


namespace ListExercise
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchPageB : ContentPage
    {
        List<SearchGroup3> _searchGroups = new List<SearchGroup3>();

        SearchService searchService = new SearchService();
               
        void Handle_Textchanged(object sender, TextChangedEventArgs e)
        {
            _searchGroups = new List<SearchGroup3>()
            {
                new SearchGroup3("Recent Searches", searchService.GetSearches(e.NewTextValue))
            };

            listView.ItemsSource = _searchGroups;
        }

        void Delete_Clicked(object sender, System.EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var search = menuItem.CommandParameter as Search;

            //Deletes from back end
            searchService.DeleteSearch(search.Id);

            //Delete from front end
            _searchGroups[0].Remove(search);
        }

        public SearchPageB()
        {
            InitializeComponent();

            _searchGroups = new List<SearchGroup3>()
            {
                new SearchGroup3("Recent Searches", searchService.GetSearches())
            };

            listView.ItemsSource = _searchGroups;
        }
    }
}