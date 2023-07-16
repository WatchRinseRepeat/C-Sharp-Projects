using Microsoft.EntityFrameworkCore;


namespace CodeFirst { 
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { FirstName = "Bob", LastName = "Densley", Age = 13 };


                ctx.Database.EnsureCreated();
                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }

    }


    public class SchoolContext: DbContext
    {
        public SchoolContext(): base()
        {

        }
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\ProjectsV13;Database=myDb;Trusted_Connection=true;");
            }
            base.OnConfiguring(optionsBuilder);
        }
        

        public DbSet<Student> Students { get; set;}

    }

}