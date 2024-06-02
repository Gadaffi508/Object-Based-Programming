using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_based_programming
{
    public class Genetic
    {

    }
    #region Game
    class Game
    {
        public int Score { get; set; }
        public bool Start { get; set; }
        public bool Over { get; set; }

        public virtual void Guess(Random rnd)
        {

        }
    }

    class NumberGuessGame : Game
    {
        public int numberGuess;

        public override void Guess(Random rnd)
        {
            int randomNumber = rnd.Next(10);

            numberGuess = Convert.ToInt32(Console.ReadLine());

            if (randomNumber == numberGuess) Console.WriteLine("True Answer");
        }
    }

    class DayGuessGame : Game
    {
        public string[] dayGuess = { "p", "s", "ç", "p", "c", "c", "p" };

        public override void Guess(Random rnd)
        {
            int randomNumber = rnd.Next(6);

            string answer = Console.ReadLine();

            if (answer == dayGuess[randomNumber])
            {
                Console.WriteLine("True Answer");
            }

        }
    }
    #endregion

    #region UserLogin
    class UserLogin
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    class ProductUser : UserLogin
    {
        public string Name { get; set; }
        public string SurName { get; set; }
    }

    class ProductStudent : ProductUser
    {
        public string StudentNumber { get; set; }
    }
    #endregion

    #region Ovveride_and_Virtual
    class Mathematic
    {
        public virtual int Area()
        {
            return 0;
        }
    }

    class Circle : Mathematic
    {
        public int r;
        public override int Area()
        {
            return 2 * r * r;
        }
    }
    #endregion

    #region User_Inheritance
    class User
    {
        public string UserName { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public bool IsActive { get; set; }
    }

    class Teacher : User
    {

    }

    class Studenta : User
    {
        string course = "Software";
        public string StudentNumber;
        public string Course
        {
            get
            {
                if (IsActive == true) return course;
                else return "Student Active False";
            }
            set
            {
                course = value;
            }
        }
    }
    #endregion

    #region Inheritance
    class Live
    {
        public int age;
        public int weight;
        public int orjin;
    }

    class Plant : Live
    {
        public string fruit;
        public int oxygenAmount;
    }

    class Human : Live
    {
        public string work;
        public float speed;
    }
    #endregion
}
