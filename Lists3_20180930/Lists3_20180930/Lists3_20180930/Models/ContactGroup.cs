using System;
using System.Collections.Generic;
using System.Text;

namespace Lists3_20180930.Models
{
    public class ContactGroup : List<Contact>
    {
        public string Title { get; set; }
        public string ShortTitle { get; set; }

        public ContactGroup(string title, string shortTitle)
//        public ContactGroup(string title)
        {
            Title = title;
            ShortTitle = shortTitle;
        }

    }
}
