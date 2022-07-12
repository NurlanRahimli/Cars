using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class MERCEDES : CAR
    {
        public string brand;
        public int price;
        public int speed;
        public string color;

        public MERCEDES(string b, int p, int s, string c)
        {
            brand = b;
            price = p;
            speed = s;
            color = c;

            Console.WriteLine($"Custom construktor worked");
        }

        public string GetDetails()
        {
            return $"{brand}, {price}, {speed}, {color}";
        }
    }
}
