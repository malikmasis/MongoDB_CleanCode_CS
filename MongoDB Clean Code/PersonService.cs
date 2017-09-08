using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDB_Clean_Code
{
    public class PersonService
    {
        private readonly IPerson _person;

        public PersonService(IPerson person)
        {
            _person = person;
        }

        public bool ChangeStock(string a, string b)
        {

            string person;
            try
            {
                person = _person.ChangeLocationNameSurname(b,a);

            }
            catch (Exception ex)
            {
                return false;
            }
            if(person == (a + b))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}

