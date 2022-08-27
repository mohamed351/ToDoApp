using Microsoft.EntityFrameworkCore;

namespace ToDoAppService.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {

        }

        public DbSet<ToDo> ToDos { get; set; }
    }
}
