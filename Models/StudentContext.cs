using Microsoft.EntityFrameworkCore;


namespace obss1.Models
{
    public class StudentContext:DbContext
    {
        public StudentContext() { }
        public StudentContext(DbContextOptions<StudentContext> options) : base(options) { }
        public DbSet<StudentModel> studentModels { get; set; }
        public DbSet<UserModel> userModels { get; set; }


    }
}
