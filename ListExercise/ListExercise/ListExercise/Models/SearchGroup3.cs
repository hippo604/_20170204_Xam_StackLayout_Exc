using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ListExercise.Models
{
    //ObservableCollection<Search> required for "base" ...
    class SearchGroup3 : ObservableCollection<Search>
    {
        public string Title { get; set; }
        public IEnumerable<Search> Searches;

        //... and base is needed for listView to display searches properly
        public SearchGroup3(string title, IEnumerable<Search> searches) 
            : base(searches)
        {
            Title = title;
            Searches = searches;
        }
    }
}
