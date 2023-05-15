using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Zadacha21
{
    public class Program
    {
        public static void Main()
        {
            string ip = Console.ReadLine();
            Regex regex = new Regex("^((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9]?)\\.){3}(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9]?)$");
            Match  matches = regex.Match(ip);

     if (matches.Success)
     {
     Console.WriteLine("IP: " + matches.Value);
     }
     else
     {
     Console.WriteLine("Совпадений нет.");
     }

    }
}
