using DTO;

namespace BLL {
    public class BookBLL {
        public static async Task<List<DTO.Book>> getList() {
            return await new DAO.BookDAO().All();
        }

        public static async Task<List<DTO.Book>> Find(string name) {
            return await new DAO.BookDAO().Find(name);
        }

        public async Task<bool> InsertNewRecord(Book book) {
            return await new DAO.BookDAO().InsertOneRecordAsync(book);
        }

        public async Task<bool> DeleteRecord(string bookid) {
            return await new DAO.BookDAO().DeleteOneRecord(bookid);
        }

        public async Task<bool> UpdateRecord(Book book) {
            return await new DAO.BookDAO().UpdateOneRecord(book);
        }
    }
}