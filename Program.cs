using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){"Mercury", "Mars"};
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            List<string> planetListB = new List<string>(){"Uranus", "Neptune"};
            planetList.AddRange(planetListB);
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");
            Console.WriteLine(planetList);

            string[] rockyPlanets = planetList.GetRange(0,4).ToArray();

            planetList.RemoveAt(8);


            foreach(string x in planetList){
                Console.WriteLine(x);
            }   
        }
    }
}
