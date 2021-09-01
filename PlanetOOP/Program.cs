using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Planet> planets = new List<Planet>();



            Planet Mecury = new Planet("Mecury", 0.330, 4879, 5427, 3.7, 1407.6, 4222.6, 57.9, 88.0, 47.4, 167, 0, "No");
            planets.Add(Mecury);

            Planet Venus = new Planet("Venus", 0.330, 4879, 5427, 3.7, 1407.6, 4222.6, 57.9, 88.0, 47.4, 167, 0, "no");
            planets.Add(Venus);

            Planet Earth = new Planet("Earth", 5.97, 12756, 5514, 9.8, 23.9, 24.0, 149.6, 365.2, 29.8, 15, 1, "No");
            planets.Add(Earth);

            Planet Mars = new Planet("Mars", 0.642, 6792, 3933, 3.7, 24.6, 24.7, 227.9, 687.0, 24.1, -65, 2, "No");
            planets.Add(Mars);

            Planet Jupiter = new Planet("Jupiter", 1898, 142984, 1326, 23.1, 9.9, 9.9, 778.6, 4431, 13.1, -110, 67, "Yes");
            planets.Add(Jupiter);

            Planet Saturn = new Planet("Saturn", 568, 120536, 687, 9.0, 10.7, 10.7, 1433.5, 10747, 9.7, -140, 62, "Yes");
            planets.Add(Saturn);

            Planet Uranus = new Planet("Uranus", 86.8, 51118, 1271, 8.7, -17.2, 17.2, 2872.5, 30589, 6.8, -195, 27, "Yes");
            planets.Add(Uranus);

            Planet Neptune = new Planet("Neptune", 102, 49528, 1638, 10.0, 16.1, 16.1, 4495.1, 59.8, 5.4, -200, 14, "Yes");
            planets.Add(Neptune);

            Planet Pluto = new Planet("Pluto", 0.0146, 2370, 2095, 0.7, -153.3, 153.3, 5906.4, 90.56, 4.7, -255, 5, "No");
            planets.Add(Pluto);

            for (int i = 0; i < planets.Count; i++)
            {
                if (planets[i] == Pluto)
                {
                    planets.Remove(Pluto);
                }
            }

            Planet Pluto1 = new Planet("Pluto", 0.0146, 2370, 2095, 0.7, -153.3, 153.3, 5906.4, 90.56, 4.7, -255, 5, "No");
            planets.Add(Pluto1);


            //foreach (var planet in planets)
            //{
            //    Console.WriteLine(planet.Name);
            //}

            //Console.WriteLine("There are " + planets.Count + " elements");


            List<Planet> mean = new List<Planet>();

            for (int i = 0; i < planets.Count; i++)
            {
                if (planets[i].MeanTemperture < 0)
                {
                    mean.Add(planets[i]);
                    
                }
            }

            List<Planet> diame = new List<Planet>();

            for (int i = 0; i < planets.Count; i++)
            {
                if (planets[i].Diameter >= 10000 && planets[i].Diameter < 50000 )
                {
                    diame.Add(planets[i]);
                }
            }

            planets.Clear();
            diame.Clear();
            mean.Clear();

            Console.WriteLine(planets);
            Console.WriteLine();
            


                Console.ReadKey();
            
        }
    }
}