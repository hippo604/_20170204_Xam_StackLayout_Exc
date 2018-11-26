using System;
using System.Collections.Generic;
using System.Text;

namespace NavigationExercise.Models
{
    public class User
    {
        public int Id { get;}
        public string Name { get;}
        public string Description { get;}
        public string ImageUrl { get;}

        public User(int id, string description, string name)
        {
            Id = id;
            Description = description;
            Name = name;
            ImageUrl = "https://via.placeholder.com/200x200/ff7f7f/333333?text=" + Id.ToString();
        }
    }
}
