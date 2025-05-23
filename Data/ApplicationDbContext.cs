using DiaryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DiaryApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        // Constructor 
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
                
        }

        public DbSet<DiaryEntry> DiaryEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<DiaryEntry>().HasData(
                new DiaryEntry { Id = 1, Title = "Went Hiking", Content = "Went Hiking with Joe and Anne!", Created = new DateTime(2024, 05, 01, 10, 0, 0) },
                new DiaryEntry { Id = 2, Title = "Went Shopping", Content = "Went Shopping with my imaginary girlfriend!", Created = new DateTime(2024, 05, 02, 14, 30, 0) },
                new DiaryEntry { Id = 3, Title = "Went Diving", Content = "Went Diving with Joe!", Created = new DateTime(2024, 05, 03, 9, 15, 0) },
                new DiaryEntry { Id = 4, Title = "Walking to the Moon.", Content= "Walked some 385,000 kilometers. Leg Day.", Created = new DateTime(2002, 08, 16, 7, 55, 22) },
                new DiaryEntry { Id = 5, Title = "Visiting Mechanic Claude.", Content = "Scrapping my Rolls Royce.", Created = new DateTime (2030, 04, 15, 2, 10, 0) }
                );
        }

        // Four steps to add a table
        // 1. Create a Model Class - DiaryEntry.cs created already
        // 2. Add DB Set
        // 3. add-migration AddDiaryEntryTable
        // 4. update-database
    }
}
