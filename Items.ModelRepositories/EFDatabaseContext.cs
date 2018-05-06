using Microsoft.EntityFrameworkCore;
using Items.DataModels;

namespace Items.DataStore
{

    public class EFDatabaseContext : DbContext
    {
        public DbSet<Item> Items{ get; set; }

        private readonly string _databasePath;

        public EFDatabaseContext(string databasePath)
        {
            _databasePath = databasePath;

            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(string.Format("Filename={0}", _databasePath));
        }
    }
}
