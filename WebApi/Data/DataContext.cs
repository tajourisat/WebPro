using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Data
{

    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
       
        public DbSet<Value> ValueInfo { get; set; }
        public DbSet<User> Users { get; set; }

    }

}