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
        SearchService searchService = new SearchService();

        void Handle_Textchanged(object sender, TextChangedEventArgs e)
        {
            listView.ItemsSource = new List<SearchGroup3>()
            {
                new SearchGroup3("Recent Searches", searchService.GetSearches(e.NewTextValue))
            };
        }

        public SearchPageB()
        {
            InitializeComponent();

            listView.ItemsSource = new List<SearchGroup3>()
            {
                new SearchGroup3("Recent Searches", searchService.GetSearches())
            };
        }


    }
}