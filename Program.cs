using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){"Mercury", "Mars"};
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            List<string> planetListB = new List<string>(){"Uranus", "Neptune"};
            planetList.AddRange(planetListB);
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            planetList.Add("Pluto");
            Console.WriteLine(planetList);

            string[] output = planetList.GetRange(2,2).ToArray();

            planetList.RemoveAt(8);


            foreach(string x in planetList){
                Console.WriteLine(x);
            }   
        }
    }
}
