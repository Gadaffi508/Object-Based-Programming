using Object_based_programming.DataBase;
using ObjectBasedProgramming;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Object_based_programming
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello");

        /*var db = new ApplicationDbContext();

        StudentData s1 = new StudentData();

        s1.StudentID = 31;

        db.Add(s1);
        db.SaveChanges();

        var stn = db.Students.ToList();

        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand.CommandText =
            ("insert into Student (studentID) values (@)studentID");
        da.SelectCommand.Parameters.AddWithValue("studentID", "31");*/
    }

}
