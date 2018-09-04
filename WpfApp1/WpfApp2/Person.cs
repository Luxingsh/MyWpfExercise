using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WpfApp2
{
    class Person
    {
       public string personName = "N.A";
        public string firstName = "N.A";
        public string lastName = "N.A";
        public string homeTown = "N.A";

        public string PersonName
        {
            get
            {
                return personName;
            }
            set
            {
                personName = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string HomeTown
        {
            get
            {
                return homeTown;
            }
            set
            {
                homeTown = value;
            }
        }
    }
}
