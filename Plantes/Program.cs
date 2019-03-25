using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantesOpgH1
{
    class Program
    {
        static void Main(string[] args)
        {
            Planet logic = new Planet();

            Planet Mercury = new Planet("Mercury", 0.330, 4879, 5427, 3.7, 1407.6, 4222.6, 57.9, 88.0, 47.4, 167, 0, false);
            Planet Earth = new Planet("Earth", 5.97, 12756, 5514, 9.8, 23.9, 24.0, 149.6, 365.2, 29.8, 15, 1, false);
            Planet Mars = new Planet("Mars", 0.642, 6792, 3933, 3.7, 24.6, 24.7, 227.9, 687.0, 24.1, -65, 2, false);
            Planet Jupiter = new Planet("Jupiter", 1898, 142984, 1326, 23.1, 9.9, 9.9, 778.6, 4331, 13.1, -110, 67, true);
            Planet Saturn = new Planet("Saturn", 568, 120536, 687, 9.0, 10.7, 10.7, 1433.5, 10747, 9.7, -140, 62, true);
            Planet Uranus = new Planet("Uranus", 86.8, 51118, 1271, 8.7, -17.2, 17.2, 2872.5, 30589, 6.8, -195, 27, true);
            Planet Neptune = new Planet("Neptune", 102, 49528, 1638, 11.0, 16.1, 16.1, 4495.1, 59800, 5.4, -200, 14, true);
            Planet Pluto = new Planet("Pluto", 0.0146, 2370, 2095, 0.7, -153.3, 153.3, 5906.4, 90560, 4.7, -225, 5, false);
            Planet Venus = new Planet("Venus", 4.87, 12104, 5243, 8.9, -5832.5, 2802.0, 108.2, 224.7, 35.0, 464, 0, false);

            PrintList(logic.Plantes);

            Console.WriteLine(logic.Name);

            //Removes Steve
            //Bye Bye Steve
            //logic.Plantes.Remove(steve);
            //R.I.P. steve




            //foreach (Planet e in logic.Plantes) {
            //    Console.WriteLine(e.Name);
            //    Console.WriteLine();
            //}

            //checks if the temperatur is below 0
            //and if it is below 0 add to meanplanet
            Console.WriteLine("Mean planned");
            List<Planet> MeanPlanet = new List<Planet>();
            foreach(Planet eee in logic.Plantes)
            {
              //  PrintList(logic.Plantes);
                if (eee.MeanTemperature <= 0)
                {
                    MeanPlanet.Add(eee);
                }
            }
            PrintList(MeanPlanet);
            



            Console.ReadLine();
        }
        //If typed planetlist();
        //its like console.writeline but better
        public static void PrintList(List<Planet> planetList)
        {
            foreach (Planet planet in planetList)
            {
                Console.WriteLine(planet.Name);
            }
            Console.WriteLine("\n");

        }
    }
}
