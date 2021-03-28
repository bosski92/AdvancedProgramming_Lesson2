using Microsoft.EntityFrameworkCore;
using AdvancedProgramming_Lesson2.Models;

namespace AdvancedProgramming_Lesson2.Data
{
    public class MvcSeriesContext : DbContext
    {
        public MvcSeriesContext(DbContextOptions<MvcSeriesContext> options)
        : base(options)
        {
        }
        public DbSet<Series> Series { get; set; }

    }
}
