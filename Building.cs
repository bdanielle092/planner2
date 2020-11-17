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

//Constructor
  public Building(string address)
  {
      _address = address ;
  }

  //Method
public void Construct()
{
    _dateConstructed = DateTime.Now;
}

public void Purchase(string buyer)
{
    _owner = buyer;
}
public void Design(string designer)
{
    _designer = designer;
}


}
}
