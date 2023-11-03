using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                return await ctx.books.Where(s => EF.Functions.Like(s.BookName, $"%{keywork}%")).ToListAsync();
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
                var books = await ctx.books.Where(s => s.BookId == book.BookId).FirstAsync();

                if (books != null) {
                    books.BookName = book.BookName;
                    books.Author = book.Author;
                    books.PublicationYear = book.PublicationYear;

                    await ctx.SaveChangesAsync();
                }
                return true;
            } catch {
                throw;
            }
        }
        public async Task<bool> DeleteOneRecord(string id) {
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
