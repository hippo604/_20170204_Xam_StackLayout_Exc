using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ListExercise.Models
{       
    class SearchGroup : IList<Search>
    {
        private List<Search> _searches = new List<Search>();

        public bool IsReadOnly { get; }
        public int Count { get; }

        public void Add(Search searchItem)
        {
        }

        public void Clear()
        {
        }

        public void CopyTo(Search[] searchArray, int arrayIndex)
        {
        }

        public bool Contains(Search searchItem)
        {
            return false;
        }

        public bool Remove(Search value)
        {
            return true;
        }

        public void RemoveAt(int index)
        {
        }

        IEnumerator<Search> IEnumerable<Search>.GetEnumerator()
        {
            return _searches.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _searches.GetEnumerator();
        }
  
        public int IndexOf(Search searchItem)
        {
            return 3;
        }

        public void Insert(int index, Search searchItem)
        {
        }

        public Search this[int index]
        {
            get
            {
                if (index<0)
                {
                    throw new Exception("index");
                }
                return _searches[index];
            }

            set
            {
                if (index < 0 && index >= _searches.Count)
                {
                    throw new Exception("index exceeded");
                }
            }
        }

        public string Title { get; set; }

        public SearchGroup(string title)
        {
            Title = title;
        }

    }
}
