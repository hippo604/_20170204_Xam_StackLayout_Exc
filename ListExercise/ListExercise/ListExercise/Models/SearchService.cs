using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ListExercise.Models
{
    class SearchService
    {
        private List<Search> _searches;

        public List<Search> GetSearches(string filter = null)
        {
            _searches = new List<Search> {
                new Search {Id="1", Location ="Taipei 台北", CheckIn = new DateTime(2018, 04, 14), CheckOut = new DateTime(2018, 04, 15) },
                new Search {Id="2", Location="Naha 那覇", CheckIn=new DateTime(2018, 04, 14), CheckOut = new DateTime(2018, 04, 15) },
                new Search {Id="3", Location="Kumamoto 熊本", CheckIn=new DateTime(2018, 06, 14), CheckOut = new DateTime(2018, 06, 15) },
                new Search {Id="4", Location="Tokyo 東京", CheckIn=new DateTime(2018, 05, 14), CheckOut = new DateTime(2018, 05, 15) }
            };

            return _searches;
        }

    }
}