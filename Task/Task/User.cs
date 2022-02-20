using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    class User
    {

        string Username;
        string Password;


       

        public User(string username, string password)
        { 
            
            if (username.Length > 6)
            {
                Username = username;
            }
            else
            {
                Console.WriteLine("Username 6dan uzun olmalidir zehmet olmasa yeniden cehd edin");
                Username = Console.ReadLine();
            }

            int count = 0;
            int countletter = 0;

            for (int i = 0; i < password.Length; i++)
            {

                if (Char.IsUpper(password[i]))
                {
                    countletter++;
                }
                if (Char.IsDigit(password[i]))
                {
                    count++;
                }

            }
            if (count != 0 && countletter != 0)
            {
                Password = password;                
            }
            else
            {
                Console.WriteLine("password-de en azi 1 reqem ve 1 boyuk herif-den istifade olunmalidir zehmet olmasa yeniden cehd edin");
                Password = Console.ReadLine();
            }

        }
        public string DetermineUsername
        {
            get
            {
                return Username;
            }
            set
            {
                if (value.Length > 6)
                {
                    Console.WriteLine("yeni username daxil edin");
                    Username = value;
                    Console.WriteLine("Username ugurla deyishdirildi yeni username:"+Username);
                }
                else
                {
                    Console.WriteLine("Username 6dan uzun olmalidir yeniden cehd edin");
                    Username = Console.ReadLine();
                }
            }
        }
        public string DeterminePassword 
        { 
            get
            {
                return Password;
            }
            set
            {
                int count = 0;
                int countletter = 0;
                for (int i = 0; i < value.Length; i++)
                {
                    if (Char.IsUpper(value[i]))
                    {
                        countletter++;
                    }                                                                                                   
                    if(Char.IsDigit(value[i]))
                    {
                        count++;
                    }
                }
                if (count!=0&&countletter!=0)
                {                   
                    Password = value;
                    Console.WriteLine("parolunuz ugurla deyishdirildi yeni parolunuz:" + Password);
                }
                else
                {                   
                    Console.WriteLine("password-de en azi 1 reqem ve 1 boyuk herif-den istifade olunmalidir zehmet olmasa yeniden cehd edin");
                    Password = Console.ReadLine();
                }
            }
        }
        public string Info()
        {
            return $"Username:{Username}\nPassword:{Password}";
        }
        
        
    }
}              
    

