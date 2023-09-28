using System;

namespace _22_09_home_work_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            AccountList al = new AccountList();
            al.SaveFile();
            al.ShowAccountList();
        }
    }
}
