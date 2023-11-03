using DTO;
using Microsoft.EntityFrameworkCore;
using Models;
namespace DAO { 
    public class BookDAO {

        private BooksContext ctx = new BooksContext();
        public async Task<List<Book>> All() {
            try {
                return await ctx.books.ToListAsync();
            } catch {
                throw;
            }
        }

        public async Task<List<Book>> Find(string keywork) {
            try {
                return await ctx.books.Where(s => EF.Functions.Like(s.Name, $"%{keywork}%")).ToListAsync();
            } catch {
                throw;
            }
        }

        public async Task<bool> InsertOneRecordAsync(Book book) {
            try {
                await ctx.books.AddAsync(book);
                int result = await ctx.SaveChangesAsync();
                if (result >= 1) {
                    return true;
                } else {
                    return false;
                }
            } catch {
                throw;
            }
        }

        public async Task<bool> UpdateOneRecord(Book book) {

            try {
                var product = await ctx.books.Where(s => s.BookId == book.BookId).FirstAsync();

                if (product != null) {
                    product.Name = book.Name;
                    await ctx.SaveChangesAsync();
                }
                return true;
            } catch {
                throw;
            }
        }
        public async Task<bool> DeleteOneRecord(int id) {
            try {
                var product = await ctx.books.Where(s => s.BookId == id).FirstAsync();

                if (product != null) {
                    ctx.books.Remove(product);
                    await ctx.SaveChangesAsync();
                }
                return true;
            } catch {
                throw;
            }
        }

    }
}
