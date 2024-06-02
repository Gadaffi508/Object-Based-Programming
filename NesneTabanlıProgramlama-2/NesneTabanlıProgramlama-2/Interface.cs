using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneTabanlıProgramlama_2
{
    public class Interface
    {
        public interface IAnimal
        {
            string Name { get; set; }

            void Speak();
        }

        public class Dog : IAnimal
        {
            public string Name { get; set; }

            public void Speak()
            {
                Console.WriteLine("Woof");
            }
        }
    }
}
