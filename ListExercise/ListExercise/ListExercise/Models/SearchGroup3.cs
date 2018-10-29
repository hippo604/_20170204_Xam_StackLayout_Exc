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

        //... which allows access members of the base class
        //so that listView displays searches properly
        public SearchGroup3(string title, IEnumerable<Search> searches) 
            : base(searches)
        {
            Title = title;
            Searches = searches;
        }
    }
}
