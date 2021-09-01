using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetOOP
{
    class Planet
    {
        // Properties
        string name;
        double mass;
        double diameter;
        double density;
        double gravity;
        double rotationperiod;
        double lenthofday;
        double distancefromsun;
        double orbitalperiod;
        double obitalvelocity;
        double meantemperture;
        double numberofmoons;
        string ringsystem;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public double Mass
        {
            get
            {
                return mass;
            }
            set
            {
                mass = value;
            }
        }
        public double Diameter
        {
            get
            {
                return diameter;
            }
            set
            {
                diameter = value;
            }
        }
        public double Density
        {
            get
            {
                return density;
            }
            set
            {
                density = value;
            }
        }
        public double Gravity
        {
            get
            {
                return gravity;
            }
            set
            {
                gravity = value;
            }
        }
        public double RotationPeriod
        {
            get
            {
                return rotationperiod;
            }
            set
            {
                rotationperiod = value;
            }
        }
        public double LenthofDay
        {
            get
            {
                return lenthofday;
            }
            set
            {
                lenthofday = value;
            }
        }
        public double DistancefromSun
        {
            get
            {
                return distancefromsun;
            }
            set
            {
                distancefromsun = value;
            }
        }
        public double OrbitalPeriod
        {
            get
            {
                return orbitalperiod;
            }
            set
            {
                orbitalperiod = value;
            }
        }
        public double ObitalVelocity
        {
            get
            {
                return obitalvelocity;
            }
            set
            {
                obitalvelocity = value;
            }
        }
        public double MeanTemperture
        {
            get
            {
                return meantemperture;
            }
            set
            {
                meantemperture = value;
            }
        }
        public double NumberofMoon
        {
            get
            {
                return numberofmoons;
            }
            set
            {
                numberofmoons = value;
            }
        }
        public string RingSystem
        {
            get
            {
                return ringsystem;
            }
            set
            {
                ringsystem = value;
            }
        }

        // Constructors
        public Planet(string Name, double Mass, double Diameter, double Density, double Gravity,
        double RotationPeriod, double LenthofDay, double DistancefromSun, double OrbitalPeriod,
        double ObitalVelocity, double MeanTemperture, double NumberofMoons, string RingSystem)
        {
            this.Name = Name;
            this.Mass = Mass;
            this.Diameter = Diameter;
            this.Density = Density;
            this.Gravity = Gravity;
            this.RotationPeriod = RotationPeriod;
            this.LenthofDay = LenthofDay;
            this.DistancefromSun = DistancefromSun;
            this.OrbitalPeriod = OrbitalPeriod;
            this.ObitalVelocity = ObitalVelocity;
            this.MeanTemperture = MeanTemperture;
            this.NumberofMoon = NumberofMoons;
            this.RingSystem = RingSystem;


        }



        // Methods

    }
}
