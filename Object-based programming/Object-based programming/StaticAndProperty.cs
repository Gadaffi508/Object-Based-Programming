using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_based_programming
{
    public class StaticAndProperty
    {
        /*Person p = new Person();

        string name = "ali";

        p.Name = name;

        p.Show();*/
    }

    class Person
    {
        private string _name = "Yusuf";

        public string Name { get { return _name; } set { _name = value; } }

        public void Show()
        {
            Console.WriteLine(_name);
        }
    }
}
