using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_YT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string characterName = "Tom";
            int characterAge = 25;

            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");

            characterName = "Mike";
            
            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge);
            Console.WriteLine("");

            string phrase = "Noah is really cool, (unlike dad)";
            char Grade = 'A';

            Console.WriteLine(phrase);
            Console.WriteLine("He is definetely going to get an " + Grade);

            double money = 3.33;

            Console.WriteLine("And he has at least £" + money);
            Console.WriteLine("How much money does he have?");
            Console.WriteLine("Nobody knows...");
            Console.WriteLine("Here is a \"");
            Console.WriteLine("(Still cool by the way)");
            Console.WriteLine("");

            Console.WriteLine("There are " + phrase.Length + " characters in the below string");
            Console.WriteLine(phrase.ToLower());
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine("");

            Console.WriteLine("");
            Console.WriteLine("True or false?");
            Console.WriteLine("The string, phrase includes the word Noah");
            Console.WriteLine("It is " + phrase.Contains("Noah"));
            Console.WriteLine("");

            Console.WriteLine("True or false?");
            Console.WriteLine("The string, phrase includes the word Oblong");
            Console.WriteLine("It is " + phrase.Contains("Oblong"));
            Console.WriteLine("");

            Console.WriteLine(phrase[0] + " Is the first letter of phrase");
            Console.WriteLine(phrase[31] + " Is the last letter of phrase");
            Console.WriteLine("Dad's first character is indexed as character: " + phrase.IndexOf("dad"));
            Console.WriteLine(phrase.Substring(29) + " is the \"word\" on character 29");
            Console.WriteLine("");

            Console.WriteLine("And the actual word is: " + phrase.Substring(29, 3));

            Console.WriteLine("Just a reminder that phrase is: " + phrase);
            Console.WriteLine("");

            Console.WriteLine("I am " + (10 + 4) + " years old.");

            double test = 1.1 + 0.9;
            Console.WriteLine(test + " is equal to 1.1 + .9");
            Console.WriteLine("The square root of 6 = " + Math.Sqrt(6));
            Console.WriteLine("12.67 rounded = " + Math.Round(12.67));
            Console.WriteLine("");

            Console.Write("What's your name? ");
            string userName = Console.ReadLine();
            Console.WriteLine("Hi " + userName + ", Nice to meet ya!");
            Console.WriteLine("");

            Console.Write("HOW OLD ARE YOU? ENTER AGE HERE: ");
            string userAge = Console.ReadLine();
            Console.WriteLine("WELCOME " + userName + " WHO IS " + userAge + " YEARS OLD");
            Console.WriteLine("");

            Console.WriteLine(userName + ", Welcome to the Calculator");
            Console.Write("Enter the first number: ");
            int calc1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int calc2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("The answer is ");
            Console.Write(calc1 + calc2);

            Console.ReadLine();
        }
    }
}