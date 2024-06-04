using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_based_programming
{
    public class ClassTutorial
    {
        Student student = new Student();
        WeightİndexCalculation indeks = new WeightİndexCalculation();
    }

    #region WorkArea
    class Value
    {
        int a;

        public void ChangeValue(int _a)
        {
            a = _a;
            Console.WriteLine(a);
        }

        public int Process
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }
    }
    #endregion

    #region Student
    class Student
    {
        private DateTime a;
        public DateTime DateOfBirth
        {
            get { return a; }
            set
            {
                if (value.Year > 2002 || value.Year < 2020)
                {
                    Console.WriteLine("Öğrenci");
                }
                else
                {
                    Console.WriteLine("Yanlış girdiniz");
                }
            }
        }
    }
    #endregion

    #region WeightIndexk
    class WeightİndexCalculation
    {
        public float height { private get; set; }
        public float weight { get; private set; }
    }
    #endregion

    #region DrivingLicense
    class DrivingLicence //Contructer
    {
        bool isDrivingLicense;

        public DrivingLicence(int Year)
        {
            if (2024 - Year > 18)
            {
                isDrivingLicense = true;
            }
            else
            {
                isDrivingLicense = false;
            }
        }
    }
    #endregion

    #region Password
    class PasswordEntered
    {
        string a;
        public string passwordController
        {
            get { return a; }
            set
            {
                if (a.Length > 8)
                {
                    Console.WriteLine("True password");
                }
                else
                {
                    Console.WriteLine("False password");
                }
            }
        }
    }
    #endregion
}
