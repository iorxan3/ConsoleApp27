using ConsoleApp27.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27.Models
{
    public class IUser:IAccount
    {
        public static int MaxId=1; //Staticde deyeri yadda saxlayir ve uzerine gelir
        public int Id { get; set; }//her userde 0 goturur
        public string FullName { get; set; }
        public string Email { get; set; } 
        public string Password { get; set; }
        public IUser(string fullname, string mail, string password)
        {
            Id = MaxId++;
            FullName = fullname;
            Email = mail;
            Password = password;
        }
        public void Info()
        {
            Console.WriteLine($"User ID: {Id}");
            Console.WriteLine($"Fullname: {FullName}");
            Console.WriteLine($"Email: {Email}");
        }
        public void checkPassword(string password)
        {
            if (password.Length > 8 &&
               password.Any(char.IsUpper) &&
               password.Any(char.IsLower) &&
               password.Any(char.IsDigit))
            {
                
                Console.WriteLine("True");
            }
            else
            {
               
                Console.WriteLine("False");
            }
        }
    }

}


