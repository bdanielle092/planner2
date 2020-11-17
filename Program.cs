using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
         Building fiveOneTwoEight = new Building("512 8th Avenue");
         Building fiveOneTwoFour = new Building("310 10th Avenue");
         Building fiveOneTwoSix = new Building("812 15th Avenue");
           
         fiveOneTwoEight.Width = 200;
         fiveOneTwoEight.Depth = 300;
         fiveOneTwoEight.Stories = 20;

         fiveOneTwoEight.Construct();

         fiveOneTwoEight.Purchase("Faith");
         fiveOneTwoEight.Design("Lacey");

         Console.WriteLine($"designed by {fiveOneTwoEight.GetDesigner()}");
        }
    }
}
