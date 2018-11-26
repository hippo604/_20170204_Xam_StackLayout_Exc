using System;
using System.Collections.Generic;
using System.Text;

namespace NavigationExercise.Models
{
    public class Activity
    {
        //These gets sets are needed for listView.
        public int UserId { get; }
        public string Description { get; }
        public string ImageUrl { get; }

        public Activity(int userId, string description)
        {
            UserId = userId;
            Description = description;
            ImageUrl = "https://via.placeholder.com/420x320/ff7f7f/333333?text=" + UserId.ToString();
        }
    }
}
