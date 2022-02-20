using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zehmet olmasa Username ve Password daxil edin");
            User user = new User(Console.ReadLine(), Console.ReadLine());
            Console.WriteLine(user.Info());

            user.DetermineUsername = Console.ReadLine();
            user.DeterminePassword = Console.ReadLine();

            Console.WriteLine(user.DetermineUsername);
            Console.WriteLine(user.DeterminePassword);

            Admin admin = new Admin(Console.ReadLine(), Console.ReadLine(),true, Console.ReadLine());
            Console.WriteLine(admin.InfoAdmin());
        }
    }
}
