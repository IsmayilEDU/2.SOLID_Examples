using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsiblity.S
{
    public static class MyFunctions
    {
        public static bool CheckLogin()
        {
            Console.WriteLine("Login checked");
            return true;
        }

        public static void LoginToApp()
        {
            Console.WriteLine("You are welcome to app");
        }

        public static void CheckLoginAndLoginToApp()
        {
            if (CheckLogin())
            {
                LoginToApp();
            }
        }
    }
}
