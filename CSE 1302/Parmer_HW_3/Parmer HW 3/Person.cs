using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Parmer_HW_3
{

    public class Person : IComparable
    {
        private string firstName;
        private string lastName;
        private int age;
        private int comparedAge;
        

        public Person(string first, string last, int Age)
        {
            firstName = first;
            lastName = last;
            age = Age;
        }
        int IComparable.CompareTo(object obj)
        {
            Person other = (Person)obj;
            this.age.CompareTo(other.age);
            comparedAge = age - other.age;
            int last = String.Compare(this.lastName, other.lastName);
            int first = String.Compare(this.firstName, other.firstName);
            if (age != 0)
                return -age;
            else if (last != 0)
                return last;
            else
                return first;
            
        }
        public override string ToString()
        {
            return age + "," + lastName + "," + firstName;
        }
    }
}