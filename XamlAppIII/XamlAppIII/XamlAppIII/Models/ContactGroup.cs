﻿using System;
using System.Collections.Generic;
using System.Text;

namespace XamlAppIII.Models
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
