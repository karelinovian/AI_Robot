using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Robot
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "привет", "как дела" };
            string[] answers = { "привет", "здравствуйте" };
            string howAreYou = "Как дела";

            string question = Console.ReadLine(); // привет || как дела

            if (question == hello)
            {
                Console.WriteLine("привет");
            }
            else if (question == howAreYou)
            {
                Console.WriteLine("нормально");
            }
            else
            {
                Console.WriteLine("Я еще маленький, я не понимаю");
            }
        }
    }
}
