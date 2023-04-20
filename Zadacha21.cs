using System;

namespace Zadacha21
{
    public class Program
    {
        public static void Main()
        {
            string ip = Console.ReadLine();
            Regex regex = new Regex("\\b((((25[0-5])|(2[0-4]\\d))|((1\\d{2})|(\\d{1,2})))\\.){3}(((25[0-5])|(2[0-4]\\d))|((1\\d{2})|(\\d{1,2})))\\b");
            MatchCollection matches = regex.Matches(ip);

            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    Console.WriteLine(match.ToString());
                }
            }
            else
            {
                Console.WriteLine("Совпадений нет.");
            }
        }

    }
}
