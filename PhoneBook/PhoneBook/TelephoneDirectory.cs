using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class TelephoneDirectory
    {

        public static List<Person> personsList = new List<Person>(50) ;

        

        public List<Person> Extend(Person obj)
        {

            TelephoneDirectory.personsList.Add(obj);
            return personsList;


        }





    }
}
