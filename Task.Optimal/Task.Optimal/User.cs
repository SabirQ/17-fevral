using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Optimal
{
    class User
    {
        string Username;
        string Password;
        public User()
        {
            Console.WriteLine("Please enter your username");
            string CheckUsername= Console.ReadLine();
            if (CheckUsername.Length>6)
            {
                Username = CheckUsername;
            }
            else
            {
                Console.WriteLine("Username has to contain more than six symbols,please try again");
                Username = Console.ReadLine();
            }
            
            Console.WriteLine("Please enter your password");

            
            string CheckPassword= Console.ReadLine();
            int Digit = 0;
            int Uppercase = 0;
            foreach (char symbol in CheckPassword)
            {
                if (Char.IsDigit(symbol))
                {
                    Digit++;
                }
                if (Char.IsUpper(symbol))
                {
                    Uppercase++;
                }
            }
            if (Digit!=0&&Uppercase!=0)
            {
                Password = CheckPassword;
            }
            else
            {
                Console.WriteLine("Password has to contain at least one number and uppercase letter please try again");
                Password = Console.ReadLine();
            }
            
        }
        public String SetGetUsername 
        { 
            get 
            {
                return Username;
            } 
            set
            {                                
                if (value.Length > 6)
                {
                    Console.WriteLine("your username succesfully changed");
                    Username = value;
                }
                else
                {
                    Console.WriteLine("Username has to contain more than six symbols,please try again");
                    Username = Console.ReadLine();
                    Console.WriteLine("your username succesfully changed");
                }
               
            }
        }
        public string GetSetPassword 
        { 
            get 
            {
                return Password;
            } 
            set
            {                              
                int Digit = 0;
                int Uppercase = 0;
                foreach (char symbol in value)
                {
                    if (Char.IsDigit(symbol))
                    {
                        Digit++;
                    }
                    if (Char.IsUpper(symbol))
                    {
                        Uppercase++;
                    }
                }
                if (Digit != 0 && Uppercase != 0)
                {
                    Console.WriteLine("your password succesfully changed");
                    Password = value;
                }
                else
                {
                    Console.WriteLine("Password has to contain at least one number and uppercase letter please try again");
                    Password = Console.ReadLine();
                    Console.WriteLine("your password succesfully changed");

                }
            }
        }
        public string Info()
        {
            return $"Username:{Username}\nPassword:{Password}";
        }
    }
}
