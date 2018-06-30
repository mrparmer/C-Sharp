using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parmer_HW_3
{

    public class Person : IComparable
    {
        private string firstName;
        private string lastName;

        public Person(string first, string last)
        {
            firstName = first;
            lastName = last;
        }
        int IComparable.CompareTo(object obj)
        {
            Person other = (Person)obj;
            int dif = String.Compare(this.lastName, other.lastName);
            if (dif != 0)
                return dif;
            return String.Compare(this.firstName, other.firstName);
        }
        public override string ToString()
        {
            return lastName + "," + firstName;
        }
    }
}