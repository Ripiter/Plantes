using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantesOpgH1
{
    class Planet
    {
        #region priviate variable
        private string name;
        private double mass;
        private double diameter;
        private double density;
        private double gravity;
        private double rotationPeriod;
        private double lenghtOfDay;
        private double distanceFromSun;
        private double orbitalPeriod;
        private double orbitalVelocity;
        private double meanTemperature;
        private double numberOfMoons;
        private bool ringSystem;
        #endregion

        static List<Planet> planetList = new List<Planet>();

        #region Get set private
        public  List<Planet> Plantes
        {
            get
            {
                return planetList;
            }
            set
            {
                planetList = value;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public double Mass
        {
            get
            {
                return this.mass;
            }
            set
            {
                this.mass = value;
            }
        }
        public double Diameter
        {
            get
            {
                return this.diameter;
            }
            set
            {
                this.diameter = value;
            }
        }
        public double Density
        {
            get
            {
                return this.density;
            }
            set
            {
                this.density = value;
            }
        }
        public double Gravity
        {
            get
            {
                return this.gravity;
            }
            set
            {
                this.gravity = value;
            }
        }
        public double RotationPeriod
        {
            get
            {
                return this.rotationPeriod;
            }
            set
            {
                this.rotationPeriod = value;
            }
        }
        public double LenghtOfDay
        {
            get
            {
                return this.lenghtOfDay;
            }
            set
            {
                this.lenghtOfDay = value;
            }
        }
        public double DistanceFromSun
        {
            get
            {
                return this.distanceFromSun;
            }
            set
            {
                this.distanceFromSun = value;
            }
        }
        public double OrbitalPeriod
        {
            get
            {
                return this.orbitalPeriod;
            }
            set
            {
                this.orbitalPeriod = value;
            }
        }
        public double OrbitalVelocity
        {
            get
            {
                return this.orbitalPeriod;
            }
            set
            {
                this.orbitalPeriod = value;
            }
        }
        public double MeanTemperature
        {
            get
            {
                return this.meanTemperature;
            }
            set
            {
                this.meanTemperature = value;
            }
        }
        public double NumberOfMoons
        {
            get
            {
                return this.numberOfMoons;
            }
            set
            {
                this.numberOfMoons = value;
            }
        }
        public bool RingSystem
        {
            get
            {
                return this.ringSystem;
            }
            set
            {
                this.ringSystem = value;
            }
        }
        #endregion

        public Planet() { }
        public Planet(string name, double mass, double diameter, double density, double gravity,
                      double rotationPeriod, double lenghtOfDay, double distanceFromSun, double orbitalPeriod,
                      double  orbitalVelocity, double meanTemperature, double numberOfMoons, bool ringSystem)
        {
            //This. points at the --> Planet(...) 
            this.name = name;
            this.mass = mass;
            this.diameter = diameter;
            this.density = density;
            this.gravity = gravity;
            this.rotationPeriod = rotationPeriod;
            this.lenghtOfDay = lenghtOfDay;
            this.distanceFromSun = distanceFromSun;
            this.orbitalPeriod = orbitalPeriod;
            this.orbitalVelocity = orbitalVelocity;
            this.meanTemperature = meanTemperature;
            this.numberOfMoons = numberOfMoons;
            this.ringSystem = ringSystem;

            planetList.Add(this);

        }

    }
}
