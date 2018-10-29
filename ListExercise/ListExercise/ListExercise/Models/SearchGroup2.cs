using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ListExercise.Models
{
    class SearchGroup2 : List<Search>
    {
        public string Title { get; set; }

        public SearchGroup2(string title)
        {
            Title = title;
        }


    }
}
