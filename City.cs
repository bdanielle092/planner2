using System;
using System.Collections.Generic;

namespace Planner
{
    public class City
    {
        //properties of the City
         public string Name {get; set;}
         public string Mayor {get; set;}
         public  DateTime YearEstablished {get; set;}

         public string NumOfBuildings {get; set;}
         
         //getting a empty list of buildings = new building 
         public List<Building> getAllBuildings = new List<Building>();

        
        //method to AddBuildings 
public void AddBuildings(Building building)
{
     getAllBuildings.Add(building);
}


    }
}