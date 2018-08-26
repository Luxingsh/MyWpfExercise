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
    }
}
