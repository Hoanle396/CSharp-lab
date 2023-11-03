// See https://aka.ms/new-console-template for more information
using DTO;
using DAO;

List<Book> list = await new BookDAO().All();

foreach (Book j in list) {
    Console.WriteLine($"{j.Name},{j.BookId}");
}

bool i = await new BookDAO().UpdateOneRecord(new Book {
    BookId = 2,
    Name = "Test",
});

Console.WriteLine($"Update: {i}");

bool c = await new BookDAO().InsertOneRecordAsync(new Book {
    Publication = "27/03/2022",
    Name = "Test 1",
});

Console.WriteLine($"Insert: {c}");

List<Book> lists = await new BookDAO().All();

foreach (Book k in lists) {
    Console.WriteLine($"{k.Name},{k.BookId}");
}

bool d = await new BookDAO().DeleteOneRecord(2);

Console.WriteLine($"Delete: {d}");

List<Book> lists1 = await new BookDAO().All();

foreach (Book kz in lists1) {
    Console.WriteLine($"{kz.Name},{kz.BookId}");
}