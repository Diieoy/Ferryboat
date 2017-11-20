using Fb.Interfaces;
using System;

namespace Fb.TypeOfCargo
{
    class Person : IGetMass
    {
        private double mass;

        public double Mass { get => mass; set => mass = value; }

        protected Person() { }
        public Person(double mass)
        {
            this.mass = mass;
        }

        public override string ToString()
        {
            return String.Format("{0} -> Mass = {1} kg;", GetType().Name, mass);
        }

        double IGetMass.GetMass()
        {
            return mass;
        }
    }
}
