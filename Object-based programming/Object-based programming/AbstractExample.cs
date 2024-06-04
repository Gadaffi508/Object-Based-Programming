using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_based_programming
{
    public class AbstractExample
    {
        //Abstract class nesne üretirken bir şablon oluşturmak istememizdir diyebiliriz. 
        //Yani bir sınıf üzerinde bulunan özellikleri kullanarak yeni bir sınıf türetmek istediğimiz zaman,
        //içerisinde bulunan bazı temel yapıları yeniden oluşturmak için override (aşırı yükleme)
        //işlemini uygular ve sınıf yapılarına göre özel bir hale getiririz.

        void Example()
        {

        }
    }

    interface İnterfaceExample
    {
        //yapısı gereği diğer sınıflara yol gösterici, rehberlik yapmak için oluşturulan,
        //kendisinden implement edilen bir sınıfa doldurulması zorunlu olan bazı özelliklerin aktarılmasını sağlayan bir kavramdır.
    }

    abstract class X
    {
        public abstract int A { get; set; }
    }

    class Y : X
    {
        public int B { get; set; }
        public override int A { get; set; }
    }

    abstract class Link
    {
        public abstract string Text { get; set; }

        public abstract string URL { get; set; }
    }

    class PersonWeb : Link
    {
        public override string Text { get; set; }
        public override string URL { get; set; }
    }

    abstract class Students
    {
        public abstract int TCnumber { get; set; }
        public abstract int StudentNumber { get; set; }
        public abstract string Name { get; set; }
        public abstract string SurName { get; set; }
    }

    interface IPerson
    {
        int ID { get; set; }
        string Name { get; set; }
        string SurName { get; set; }
        int TC { get; set; }

        void Work();
    }

    class SpeacialPerson : IPerson
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int TC { get; set; }

        public void Work()
        {

        }
    }
    abstract class Shape
    {
        public abstract double area { get; set; }

        public abstract void NumberOfDiagonals();

        public virtual void Draw()
        {
            //
        }
    }

    class Circles : Shape
    {
        public override double area { get; set; }

        public override void NumberOfDiagonals()
        {
            Console.WriteLine("Circle");
        }

        public override void Draw()
        {
            Console.WriteLine("Circle");
        }
    }
}
