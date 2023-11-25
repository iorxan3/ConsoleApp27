using ConsoleApp27.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27.Models
{
    internal class İStudent:IAccount 
    {
        public static int MaxId = 1;
        public int Id;
        public string FullName;
        public double Point;

        public İStudent(string fullname, double point)
        {
            Id = MaxId++;
            FullName = fullname;
            Point = point;
        }

        public void checkPassword(string password)
        {
            throw new NotImplementedException();
        }

        public void Info()
        {
            throw new NotImplementedException();
        }

        public void StudentInfo()
        {
            Console.WriteLine($"User ID: {Id}");
            Console.WriteLine($"Fullname: {FullName}");
            Console.WriteLine($"Point: {Point}");
        }
    }
}
    
