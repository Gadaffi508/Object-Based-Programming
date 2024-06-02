using Object_based_programming;
using Object_based_programming.DataBase;
using Microsoft.EntityFrameworkCore;


namespace ObjectBasedProgramming
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
        }
    }

    public class ApplicationDbContext : DbContext
    {
        public static string constr = "Data Source=104.247.167.130\\MSSQLSERVER2022;Initial Catalog=omerarpa_edu;User ID=omerarpa_edu;Password=1n499&Zof;TrustServerCertificate=true";

        public DbSet<StudentData> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(constr);
            }
        }
    }
}