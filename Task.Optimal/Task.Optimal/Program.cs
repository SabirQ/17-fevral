using System;

namespace Task.Optimal
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Console.WriteLine(user.Info());
            user.SetGetUsername = Console.ReadLine();
            user.GetSetPassword = Console.ReadLine();
            Admin abc = new Admin();
            Console.WriteLine(abc.InfoAdmin());
        }
    }
}
