using System;
using System.Collections.Generic;
using System.Linq;

namespace jobbOffer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> pwdList = new List<string> { "Ib#", "Blo", "F09", "Hkf", "Ev!", "K%2", "Awe", "Cve", "Lee", "J61", "Gvc", "Dde" };
            List<string> skillList = new List<string> { ".Net Core", "XAML", "WPF", "ASP MVC", "LINQ" };

            string test1 = pwdList.Take(1).Aggregate((i, j) => i + j);
            string test1sub = pwdList.Take(1).Aggregate((i, j) => i + j.Substring(1, 2));
            string test2=  pwdList.Take(2).Aggregate((i, j) => i + j);
            string test2sub = pwdList.Take(2).Aggregate((i, j) => i + j.Substring(1, 2));
            string test5 = pwdList.Take(5).Aggregate((i, j) => i + j);

            string test5sub = pwdList.Take(5).Aggregate((i, j) => i + j.Substring(1, 2));

            string password = pwdList.Take(5).Aggregate((i, j) => i + j.Substring(1, 2)).Substring(1);
            Console.WriteLine("Give this password to Nathalie our HR manager: " + password);

            Console.ReadKey();
        }
    }
}

