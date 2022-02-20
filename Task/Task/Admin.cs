using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    class Admin:User
    {
        public bool IsSuperAdmin;
        public string Section;
        
        public Admin(string username, string password,bool issuperadmin,string section):base(username,password)
        {
            IsSuperAdmin = issuperadmin;
            Section = section;
            
        }
        public string InfoAdmin()
        {
            string SuperAd;
            if (IsSuperAdmin == true)
            {
                SuperAd = "yes";
            }
            else
            {
                SuperAd = "no";
            }
            return Info()+$"\nIsSuperAdmin:{SuperAd}\nSection:{Section}";
        }
    }
}
