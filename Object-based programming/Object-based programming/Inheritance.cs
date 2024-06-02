using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_based_programming
{
    public class Inheritance
    {

    }

    class Liven
    {
        public string name { get; set; }
        public int age { get; set; }

        protected string property;

        public Liven(string _name, int _age)
        {
            Console.WriteLine(_name + " " + _age);
        }

        public virtual void Show()
        {
            Console.WriteLine("Live class");
        }
    }

    class Mammal : Liven
    {
        public Mammal(string _name, int age) : base(_name, age)
        {

        }

        public override void Show()
        {
            Console.WriteLine("Mammal");
        }
    }

    class Dog : Liven
    {
        public Dog(string _name, int age) : base(_name, age)
        {

        }

        public override void Show()
        {
            Console.WriteLine("Dog");
        }
    }

    class GameEngine : Unity, UnrealEngine
    {
        public string SoftwareName { get; set; }

        public void Software()
        {

        }
    }

    interface Unity
    {
        public string SoftwareName { get; set; }
        void Software();
    }

    interface UnrealEngine
    {
        public string SoftwareName { get; set; }
        void Software();
    }
}
