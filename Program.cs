using System;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Bobby";
            if (IsNameValid(name))
            {
                Console.WriteLine($"{name} is a valid name.");
            }
            else
            {
                Console.WriteLine($"{name} is not a valid name.");
            }
            string name2 = "bobby";
            if (IsNameValid(name2))
            {
                Console.WriteLine($"{name2} is a valid name.");
            }
            else
            {
                Console.WriteLine($"{name2} is not a valid name.");
            }

            string email = "Bobby12@gmail.com";
            if (IsEmailValid(email))
            {
                Console.WriteLine($"{email} is a valid email.");
            }
            else
            {
                Console.WriteLine($"{email} is not a valid email.");
            }
            string email2 = "Bobby12@gml.c";
            if (IsEmailValid(email2))
            {
                Console.WriteLine($"{email2} is a valid email.");
            }
            else
            {
                Console.WriteLine($"{email2} is not a valid email.");
            }

            string number = "734-678-2431";
            if (IsPhoneNumValid(number))
            {
                Console.WriteLine($"{number} is a valid phone number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a valid phone number.");
            }
            string number2 = "7341-678-2431";
            if (IsPhoneNumValid(number2))
            {
                Console.WriteLine($"{number2} is a valid phone number.");
            }
            else
            {
                Console.WriteLine($"{number2} is not a valid phone number.");
            }

            string HTML = "<p> some text </p>";
            if (IsValidHTML(HTML))
            {
                Console.WriteLine($"{HTML} is a valid HTML tag.");
            }
            else
            {
                Console.WriteLine($"{HTML} is not a valid HTML tag.");
            }
            string HTML2 = "<p> some text <p>";
            if (IsValidHTML(HTML2))
            {
                Console.WriteLine($"{HTML2} is a valid HTML tag.");
            }
            else
            {
                Console.WriteLine($"{HTML2} is not a valid HTML tag.");
            }
        }
        static bool IsNameValid(string name)
        {
            if (Regex.IsMatch(name.Trim(), "^[A-Z]{1}[A-Za-z]+$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool IsEmailValid(string email)
        {
            // 
            if (Regex.IsMatch(email.Trim(), "[A-z0-9]{5,30}@[A-z0-9]{5,10}.[A-z0-9]{2,3}"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool IsPhoneNumValid(string num)
        {
            if (Regex.IsMatch(num.Trim(), "^[0-9]{3}-{1}[0-9]{3}-{1}[0-9]{4}$"))

            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool IsValidHTML(string code)
        {
            // <p> </p>
            if (Regex.IsMatch(code.Trim(), "^([<]{1}[A-z]+[>]{1}).*([<]{1}[/]{1}[A-z]+[>]{1})$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}