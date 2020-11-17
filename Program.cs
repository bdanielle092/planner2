using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
        //create several building 
        //building is the type  fiveOneTwoEight is the variable and new building is construted it 
         Building fiveOneTwoEight = new Building("512 8th Avenue");
         Building fiveOneTwoSix = new Building("812 15th Avenue");
         Building fiveOneTwoFour = new Building("310 10th Avenue");
         
           
        //give each building width, height, stories 
         fiveOneTwoEight.Width = 200;
         fiveOneTwoEight.Depth = 300;
         fiveOneTwoEight.Stories = 20;

        fiveOneTwoSix.Width = 1000;
        fiveOneTwoSix.Depth = 2000;
        fiveOneTwoSix.Stories = 200;

         fiveOneTwoFour.Width = 400;
         fiveOneTwoFour.Depth = 200;
         fiveOneTwoFour.Stories = 40;

     

        // Construct each building 
        
         fiveOneTwoEight.Design("Lacey");
         //fiveOneTwoEight is the variable and Construct is the method. We add the dot to connect the two
         fiveOneTwoEight.Construct();
         fiveOneTwoEight.Purchase("Faith");

        
         fiveOneTwoSix.Design("Rose");
         fiveOneTwoSix.Construct();
         fiveOneTwoSix.Purchase("Adam");
         
 
        
         fiveOneTwoFour.Design("Erik");
         fiveOneTwoFour.Construct();
         fiveOneTwoFour.Purchase("Tasha");


      
         fiveOneTwoEight.DisplayBuilding();
         fiveOneTwoSix.DisplayBuilding();
         fiveOneTwoFour.DisplayBuilding();

         //After all of the buildings have been purchased, display the following information to the console for each building.
        //  Console.WriteLine($"{fiveOneTwoEight.GetAddress()}");
        //  Console.WriteLine("------------------------");
        //  Console.WriteLine($"Designed by {fiveOneTwoEight.GetDesigner()}");
        //  Console.WriteLine($"Constructed on {fiveOneTwoEight.GetDateConstructed()}");
        //  Console.WriteLine($"Owned by {fiveOneTwoEight.GetPurchase()}");
        //  Console.WriteLine($"{fiveOneTwoEight.Volume}");
        //  Console.WriteLine();

        //  Console.WriteLine($"{fiveOneTwoSix.GetAddress()}");
        //  Console.WriteLine("------------------------");
        //  Console.WriteLine($"Designed by {fiveOneTwoSix.GetDesigner()}");
        //  Console.WriteLine($"Constructed on {fiveOneTwoSix.GetDateConstructed()}");
        //  Console.WriteLine($"Owned by {fiveOneTwoSix.GetPurchase()}");
        //  Console.WriteLine();


        //   Console.WriteLine($"{fiveOneTwoFour.GetAddress()}");
        //  Console.WriteLine("------------------------");
        //  Console.WriteLine($"Designed by {fiveOneTwoFour.GetDesigner()}");
        //  Console.WriteLine($"Constructed on {fiveOneTwoFour.GetDateConstructed()}");
        //  Console.WriteLine($"Owned by {fiveOneTwoFour.GetPurchase()}");
        //  Console.WriteLine();









        }
    }
}
