using System;
using System.Linq;
using System.Text;

namespace HelpfulMaths
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var numbersList = input.Split('+').Select(x => int.Parse(x)).ToList();
            var sortednumber = numbersList.OrderBy(x => x);

            var stringBuilder = new StringBuilder();
            foreach (var i in sortednumber)
            {
                stringBuilder.Append(i);
                stringBuilder.Append("+");
            }

            stringBuilder.Remove(stringBuilder.Length - 1, 1);
            Console.WriteLine(stringBuilder);
        }
    }
}