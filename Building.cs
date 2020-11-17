using System;

namespace Planner
{
  public class Building 
  {
      //private fields
      //private fields will equal something and public will be get/set
      private string _designer = "Faith Magras";
      private DateTime _dateConstructed = 10-20-2010 04:30:00;
      private string _address = "104 barker lane";
      private string _owner = "Kaylis Magras";

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
  }


}