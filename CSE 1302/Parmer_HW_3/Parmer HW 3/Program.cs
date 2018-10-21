using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Parmer_HW_3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("inputNames.txt");
            string data = sr.ReadLine();
            List<Person> person = new List<Person>();
            StreamWriter sw = new StreamWriter("outNames.txt");
            //Console.WriteLine(data);
            
            while (data != null)
            {
                Console.WriteLine(data);
                string[] values = data.Split(',');
                Person p = new Person(values[0], values[1], Int32.Parse(values[2]));
                person.Add(p);
                data = sr.ReadLine();
            }
            person.Sort();
            

            foreach (var i in person)
                //Console.WriteLine(i);
                sw.WriteLine(i);
                sw.Flush();
            sw.Close();
        }

    }
}
