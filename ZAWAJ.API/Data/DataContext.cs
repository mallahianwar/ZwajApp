using Microsoft.EntityFrameworkCore;
using ZAWAJ.API.Models;

namespace ZAWAJ.API.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
            
        }
        public DbSet<Value> Values { get; set; }
    }
}