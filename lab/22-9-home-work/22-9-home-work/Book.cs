using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_9_home_work
{
    internal class Book : IBook
    {

        public string ISBN { get; set; }
        public string Title { get;  set; }
        public string Author { get;  set; }
        public string Publisher { get;  set; }
        public int Year { get;  set; }

        private ArrayList chapter = new ArrayList();
        public string? this[int index]
        {
            get
            {
                if (index >= 0 && index < chapter.Count)
                    return (string)chapter[index];
                else
                    throw new IndexOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < chapter.Count)
                    chapter[index] = value;
                else if (index == chapter.Count)
                    chapter.Add(value);
                else
                    throw new IndexOutOfRangeException();
            }
        }
        public void Show()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Publisher: " + Publisher);
            Console.WriteLine("Year: " + Year);
            Console.WriteLine("Chapter: ");
            for (int i = 0; i < chapter.Count; i++)
                Console.WriteLine("\t{0}: {1}", i + 1, chapter[i]);
            Console.WriteLine("----------------------");
        }

        public void Input()
        {
            Console.Write("Title: ");
            Title = Console.ReadLine();

            Console.Write("Author: ");
            Author = Console.ReadLine();

            Console.Write("Publisher: ");
            Publisher = Console.ReadLine();

            Console.Write("Year: ");
            Year = Convert.ToInt32(Console.ReadLine());

            Console.Write("ISBN: ");
            ISBN = Console.ReadLine();

            string? str;
            do
            {
                str = Console.ReadLine();
                if (str?.Length > 0)
                    chapter.Add(str);
            } while (str?.Length > 0);
        }
        public int CompareTo(Book? other)
        {
            return String.Compare(Title, other?.Title);
        }
    }
}
