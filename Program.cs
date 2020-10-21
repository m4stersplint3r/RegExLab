using System;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, email, number, date, HTML;
            Console.Write("Please enter a valid name: ");
            name = Console.ReadLine();
            IsNameValid(name);            

            Console.Write("Please enter a valid email: ");
            email = Console.ReadLine();
            IsEmailValid(email);

            Console.Write("Please enter a valid phone number: ");
            number = Console.ReadLine();
            IsPhoneNumValid(number);

            Console.Write("Please enter a valid date: ");
            date = Console.ReadLine();
            IsDateValid(date);
            
            Console.Write("Please enter a valid HTML: ");
            HTML = Console.ReadLine();
            IsHTMLValid(HTML);
        }
        static bool IsNameValid(string name)
        {
            if (Regex.IsMatch(name.Trim(), "^[A-Z]{1}[A-Za-z]+$"))
            {
                Console.WriteLine($"{name} is a valid name.{Environment.NewLine}");
                return true;
            }
            else
            {
                Console.WriteLine($"{name} is not a valid name.{Environment.NewLine}");
                return false;
            }
        }
        static bool IsEmailValid(string email)
        {
            // 
            if (Regex.IsMatch(email.Trim(), "[A-z0-9]{5,30}@[A-z0-9]{5,10}.[A-z0-9]{2,3}"))
            {
                Console.WriteLine($"{email} is a valid email.{Environment.NewLine}");
                return true;
            }
            else
            {
                Console.WriteLine($"{email} is not a valid email.{Environment.NewLine}");
                return false;
            }
        }
        static bool IsPhoneNumValid(string num)
        {
            if (Regex.IsMatch(num.Trim(), "^[0-9]{3}-{1}[0-9]{3}-{1}[0-9]{4}$"))

            {
                Console.WriteLine($"{num} is a valid phone number.{Environment.NewLine}");
                return true;
            }
            else
            {
                Console.WriteLine($"{num} is not a valid phone number.{Environment.NewLine}");
                return false;
            }
        }
        static bool IsHTMLValid(string code)
        {
            // <p> </p>
            if (Regex.IsMatch(code.Trim(), "^([<]{1}[A-z]+[>]{1}).*([<]{1}[/]{1}[A-z]+[>]{1})$"))
            {
                Console.WriteLine($"{code} is a valid HTML tag.{Environment.NewLine}");
                return true;
            }
            else
            {
                Console.WriteLine($"{code} is not a valid HTML tag.{Environment.NewLine}");
                return false;
            }
        }
        static bool IsDateValid(string date)
        {
            if (Regex.IsMatch(date.Trim(), "(([0-2][0-9])|([3][01])){1}[/]{1}((0[0-9])|(1[0-2])){1}[/]{1}([0-9][0-9][0-9][0-9]){1}"))
            {
                Console.WriteLine($"{date} is a valid date.{Environment.NewLine}");
                return true;
            }
            else
            {
                Console.WriteLine($"{date} is not a valid date.{Environment.NewLine}");
                return false;
            }
        }
    }
}