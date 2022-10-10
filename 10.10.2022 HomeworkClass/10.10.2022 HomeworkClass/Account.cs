using System;
using System.Collections.Generic;
using System.Text;

namespace _10._10._2022_HomeworkClass
{
    class Account
    {
        public static void LoginPassword(string login, string passoword)
        {
            if(login == "cavid123@gmail.com" && passoword == "Cavid1993")
            {
                Console.WriteLine("Giris ugurlu");
            }
            else
            {
                Console.WriteLine("Email ve ya password sehvdir");
            }
        }
    }
}
