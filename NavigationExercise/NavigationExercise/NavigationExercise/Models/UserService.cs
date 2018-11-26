using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NavigationExercise.Models
{
    public class UserService
    {
        private List<User> _users = new List<User>
        {
            //Adapted from Mosh's resources
            //Originally: new User { Id = 4, Description = "My name is Saul", Name = "Saul" }
            new User (1, "My name is Saul", "Saul"),
            new User (2, "My name is Jonv", "Jonv"),
            new User (3, "My name is RachelMartin", "RachelMartin"),
            new User (4, "My name is Nivan Jay", "Nivan Jay")
        };

        public User GetUser(int userId)
        {
            return _users.SingleOrDefault(u => u.Id == userId);
        }
    }
}
