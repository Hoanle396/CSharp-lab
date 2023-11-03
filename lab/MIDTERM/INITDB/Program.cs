// See https://aka.ms/new-console-template for more information
using DAO;

Console.WriteLine("Hello, World!");

await new BooksContext().CreateDatabase();
