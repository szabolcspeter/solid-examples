/*
    My oppinion is this whole demo application is WRONG! Square is not a kind of Rectangle, therefore you shouldn't extend Squeare from Rectangle!
*/

using System;

namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        public static int Area(Rectangle r) => r.Width * r.Height;
        static void Main(string[] args)
        {
            Rectangle rc = new Rectangle(2, 3);
            Console.WriteLine($"{rc} has area {Area(rc)}");

            Rectangle sq = new Square();
            sq.Width = 4;
            Console.WriteLine($"{sq} has area {Area(sq)}");
        }
    }
}
