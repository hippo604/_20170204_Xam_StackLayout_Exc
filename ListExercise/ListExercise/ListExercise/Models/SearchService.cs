using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace ListExercise.Models
{
    class SearchService
    {
        private List<Search> _searches = new List<Search> {
                new Search {Id="1", Location ="Taipei 台北", CheckIn = new DateTime(2018, 04, 14), CheckOut = new DateTime(2018, 04, 15) },
                new Search {Id="2", Location="Naha 那覇", CheckIn=new DateTime(2018, 04, 14), CheckOut = new DateTime(2018, 04, 15) },
                new Search {Id="3", Location="Kumamoto 熊本", CheckIn=new DateTime(2018, 06, 14), CheckOut = new DateTime(2018, 06, 15) },
                new Search {Id="4", Location="Tokyo 東京", CheckIn=new DateTime(2018, 05, 14), CheckOut = new DateTime(2018, 05, 15) }
            };

        public IEnumerable<Search> GetSearches(string filter = null)
        {
            if (String.IsNullOrWhiteSpace(filter))
                return _searches;

            return _searches.Where(c => c.Location.StartsWith(filter, StringComparison.CurrentCultureIgnoreCase));
        }

        public void DeleteSearch(string searchId)
        {
            _searches.Remove(_searches.Single(s => s.Id == searchId));
           
        }
    }
}