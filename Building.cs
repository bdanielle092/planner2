using System;

namespace Planner
{
  public class Building 
  {
      //private fields
     // you can use the the private field inside this class but not anywhere else
      private string _designer  {get; set;}
      private DateTime _dateConstructed  {get; set;}
      private string _address {get; set;}
      private string _owner {get; set;}

     // public properties of the building 
     //get allows you access it and set allows you to assign it
     public int Stories {get; set;}
     public double Width {get; set;}
     public double Depth {get; set;}

// this is a read-only because we can only get(access the property) but you can't assign it anything
     public double Volume 
     {
         get
         {
           return Width * Depth * (3 * Stories );
         }
     
  }


// A constructor is a special method that is used to initialize objects. The advantage of a constructor, is that it is called when an object of a class is created. It can be used to set initial values for fields
//building is the constructor and address is the parameter
  public Building(string address)
  {
      _address = address ;
  }

// //Method
// Construct() is the name of the method
// public mean that you have access to this method outside this class
// void means that this method does not have a return value. 
public void Construct()
{
    _dateConstructed = DateTime.Now;
}

public void Purchase(string buyer)
{
    _owner = buyer;
}


//This Method sets the designer
public void Design(string designer)
{
    _designer = designer;
}




public void DisplayBuilding()
{
         Console.WriteLine(_address);
         Console.WriteLine("------------------------");
         Console.WriteLine($"Designed by {_designer}");
         Console.WriteLine($"Constructed on {_dateConstructed }");
         Console.WriteLine($"Owned by {_owner}");
         Console.WriteLine($"{Volume}");
         Console.WriteLine();
}
}
}
