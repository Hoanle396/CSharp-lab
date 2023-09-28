using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_09_home_work_2
{
    [Serializable]
    public class Account
    {
        private string? id;
        private string? firstName;
        private string? lastName;
        private long balance;

        public Account()
        {
            ID = "";
            FirstName = "";
            LastName = "";
            Balance = 0;
        }

        public Account(string? id, string? firstName, string? lastName, long balance)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Balance = balance;
        }

        public Account(string accountString)
        {
            string[] arrayField = accountString.Split("_");
            ID = arrayField[0];
            FirstName = arrayField[1];
            LastName = arrayField[2];
            Balance = Convert.ToInt64(arrayField[3]);
        }

        public string? ID { get => id; set { id = value; } }
        public string? FirstName { get => firstName; set { firstName = value; } }
        public string? LastName { get => lastName; set { lastName = value; } }
        public long Balance
        {
            get => balance;
            set
            {
                if (balance < 0) throw new ArgumentException("Invalid balance!");
                balance = value;
            }
        }

        public void Input()
        {
            Console.Write("Enter ID: ");
            ID = Console.ReadLine();

            Console.Write("Enter first name: ");
            FirstName = Console.ReadLine();

            Console.Write("Enter last name: ");
            LastName = Console.ReadLine();

            Console.Write("Enter balance: ");
            Balance = Convert.ToInt64(Console.ReadLine());
        }

        public void Show()
        {
            Console.WriteLine(this);
        }

        public string ToStringLine()
        {
            return $"{ID}_{FirstName}_{LastName}_{Balance}";
        }

        public override string ToString()
        {
            return $"Account[ID = {ID}, first name = {FirstName}, last name = {LastName}, balance = {Balance}]";
        }
    }
}
