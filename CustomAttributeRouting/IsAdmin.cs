using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Custom_Attribute_Routing.CustomAttributeRouting
{
    //Before Class
    [AttributeUsage(AttributeTargets.Method)]
    public class IsAdmin : Attribute
    {
        public const string ADMIN_NAME = "Mahinur Rahman Hridoy";
        public IsAdmin(string name)
        {
            if(name == ADMIN_NAME)
            {
                Console.WriteLine($"Access Granted!");
            }
            else
            {
                Console.WriteLine($"Access Denied!");
            }
        }
    }
}