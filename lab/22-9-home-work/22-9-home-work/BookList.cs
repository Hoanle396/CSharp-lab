using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_9_home_work
{
    public class BookList
    {
        private List<Book> list = new List<Book>();

        public void AddBook()
        {
            Book b = new Book();
            b.Input();
            list.Add(b);
        }

        public void ShowList()
        {
            foreach (Book b in list)
                b.Show();
        }

        public void InputList()
        {
            int n;
            Console.Write("Amount of books: ");
            n = Convert.ToInt32(Console.ReadLine());
            while (n-- > 0)
            {
                AddBook();
            }
        }
        public void SortByTitle()
        {
            list.Sort();
        }

        public void SortByYear()
        {
            list.Sort(new BookYearComparer());
        }
    }
}
