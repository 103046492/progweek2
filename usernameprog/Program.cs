﻿using System;

namespace usernameprog
{
    class Program
    {
        static void Main(string[] args)
        {
            int username;
            int password;
            
            Console.WriteLine("Enter Username");
            username = int.Parse(Console.ReadLine());
            
            
            if(username == 103046492)
                Console.WriteLine("Enter Password");
        
            else
            {
                Console.WriteLine("Wrong User");
            }
            
            password = int.Parse(Console.ReadLine());
            
            if(password == 123456)
            {
                    Console.WriteLine("Login Successful");
            }
            
            else
            { 
                Console.WriteLine("Login Unsuccessful");
            }Console.ReadLine();
        }
    }
}
