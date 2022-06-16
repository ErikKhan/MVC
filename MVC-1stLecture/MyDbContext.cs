using Microsoft.EntityFrameworkCore;
using MVC_1stLecture.Models;

namespace MVC_1stLecture
{
    public class MyDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
    }
}
