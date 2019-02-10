using System;
using System.Collections.Generic;
using System.Text;

namespace FormsExercise.Classes
{
    class Contact
    {
        public int IdContact { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Phonenumber { get; set; }
        public string Email { get; set; }
        public bool IsBlocked { get; set; }


        public Contact(int idContact,  string lastname, string firstname, int phonenumber)
        {
            IdContact = idContact;
            Firstname = firstname;
            Lastname = lastname;
            Phonenumber = phonenumber;
            Email = "...";
            IsBlocked = false;
        }

        public string FullName
        {
            // See Mosh's blog post, which includes string interpoltion syntax.
            // http://programmingwithmosh.com/csharp/csharp-6-features-that-help-you-write-cleaner-code/
            get { return $"{Firstname} {Lastname}"; }
        }
    }
}
