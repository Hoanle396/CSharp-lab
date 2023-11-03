using DTO;
using Microsoft.EntityFrameworkCore;

namespace Models {
    public class BooksContext : DbContext {
        public DbSet<Book> books { set; get; }
        public DbSet<Borrower> porrowers { set; get; }
        public DbSet<Borrow> borrows { set; get; }

        private const string connectionString = @"Data Source=localhost,1433;Initial Catalog=Student;User ID=sa;Password=123456;Trusted_Connection=True;TrustServerCertificate=True;";
        private const string connect = "Server=localhost;Database=Student;User ID=sa;Password=123456;Trusted_Connection=True;TrustServerCertificate=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connect);
        }

        public async Task CreateDatabase() {
            String databasename = Database.GetDbConnection().Database;

            Console.WriteLine("Tạo " + databasename);

            bool result = await Database.EnsureCreatedAsync();
            string resultstring = result ? "Success" : "database arealy exits";
            Console.WriteLine($"CSDL {databasename} : {resultstring}");
        }
        public async Task DeleteDatabase() {
            String databasename = Database.GetDbConnection().Database;
            bool deleted = await Database.EnsureDeletedAsync();
            string deletionInfo = deleted ? "đã xóa" : "không xóa được";
            Console.WriteLine($"{databasename} {deletionInfo}");

        }
    }
}
