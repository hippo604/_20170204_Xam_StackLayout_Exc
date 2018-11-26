using System;
using System.Collections.Generic;
using System.Text;

namespace NavigationExercise.Models
{
    public class ActivityService
    {
        public IEnumerable<Activity> GetActivities()
        {
            return new List<Activity>
            {
                new Activity(1, "Your Facebook friend Jenny Dalby is on Instagram."),
                new Activity(2, "Jonv started following you" ),
                new Activity(3, "RachelMartin liked your photo." ),
                new Activity(4, "Your Facebook friend Nivan Jay is on Instagram." )
            };
        }
    }
}
