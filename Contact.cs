using System;

namespace addressBook
{
    class Contact{

        public string FirstName {get; set;}

        public string LastName {get; set;}

        public string FullName;

        public string Email {get; set;}

        public string Address {get; set;}

        public string GetFullName(){
            return FullName = $"{FirstName} {LastName}";
        }

    }
}