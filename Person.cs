using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._02._22
{
    internal class Person
    {
        //вариант 1
        public int GetAge(DateTime birthDate)
        {
            var now = DateTime.Today;
            string err = string.Empty;
            int age;
            if (birthDate.Year < now.Year)
            {
                age = now.Year - birthDate.Year;
                if (birthDate.Month > now.Month & birthDate.Day < now.Day)
                {
                    age--;

                }

            }

            else
            {
                err = "Error";
                age = 0;
                Console.WriteLine(err);
            }
            return age;
        }

        // вариант 2
        public int _age;
        public DateTime _birthDate;
        public int Age
        {
            get
            {
                _age = DateTime.Now.Year - _birthDate.Year;
                if(DateTime.Now.Month < _birthDate.Month 
                    || (DateTime.Now.Month == _birthDate.Month && DateTime.Now.Day < _birthDate.Day))
                {
                    _age--;
                }
                return _age;
            }
        }
    }
}
