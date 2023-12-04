using System;

namespace MyApp;
class SwitchCase
{
    static void Main(string[] args)
    {
            int day = 4;
            switch (day)
            {
                case 1:Console.WriteLine("Monday"); break;
                case 2:Console.WriteLine("Tuesday");break;
                case 3: Console.WriteLine("Wednesday"); break;
                default:Console.WriteLine("Looking forward to the Weekend."); break;
            }
        }
    }
