using Microsoft.EntityFrameworkCore;


namespace obss1.Models
{
    public class StudentContext:DbContext
    {
        public StudentContext() { }
        public StudentContext(DbContextOptions<StudentContext> options) : base(options) { }

        public DbSet<StudentModel> studentModels { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder.UseNpgsql("Host=localhost; Port=5432; User Id=postgres; Password=test; Database=obss_21_02;");

    }
}
