using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Optimal
{
    class Admin:User
    {
        public bool IsSuperAdmin;
        public string Section;
        public Admin():base()
        {
            Console.WriteLine("Are you Super Admin Please use 'yes' or 'not' keywords");
            string IsSuperAD = Console.ReadLine();
            if (IsSuperAD == "yes")
            {
                IsSuperAdmin = true;
            }
            else
            {
                IsSuperAdmin = false;
            }
            Console.WriteLine("please enter your section");
            Section = Console.ReadLine();

        }
        public string InfoAdmin()
        {
            string IsSuper;
            if (IsSuperAdmin)
            {
                IsSuper = "yes";
            }
            else
            {
                IsSuper = "no";
            }
            return Info()+$"\nIs SuperAdmin:{IsSuper}\nSection:{Section}"; 
        }
    }
}
