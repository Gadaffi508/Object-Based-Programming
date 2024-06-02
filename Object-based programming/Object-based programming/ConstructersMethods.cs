using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_based_programming
{
    public class ConstructersMethods
    {

    }

    class ProductStok
    {
        public string ProductType { get; set; }
        public int ProductAmount { get; set; }
        public string ProductFrom { get; set; }

        public ProductStok()
        {

        }
        public ProductStok(string ProductType) : this()
        {

        }
        public ProductStok(int ProductAmount, string ProductType) : this(ProductType)
        {

        }
        public ProductStok(string ProductFrom, int ProductAmount, string ProductType) : this(ProductAmount, ProductType)
        {

        }
    }

    #region Person
    class PersonProperty
    {
        public string userName { get; set; }
        public int userID { get; set; }
        public string password { get; set; }

        public PersonProperty()
        {
            Console.WriteLine("Connection");
            Console.WriteLine("");
        }

        public PersonProperty(int userID, string password) : this()
        {
            Console.WriteLine("logging in : " + userID);
        }

        public PersonProperty(string userName, string password) : this()
        {
            Console.WriteLine("logging in : userName");
        }

        ~PersonProperty()
        {
            Console.WriteLine("Person login destroyed");
        }
    }
    #endregion

    #region Constructar
    /// <summary>
    /// Object Based Programing
    /// A lot of Constructer method
    /// </summary>
    class ConstructerTry
    {
        private int value = 0;

        public ConstructerTry()
        {
            value = 1;
        }

        public ConstructerTry(bool first) : this()
        {
            value = 2;
        }

        public ConstructerTry(int index) : this(true)
        {
            value = 3;
        }
    }
    #endregion
}
