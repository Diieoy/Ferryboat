using Fb.Interfaces;
using System;

namespace Fb.TypeOfCargo
{
    class Container : AbstractTypeOfCargoTransportation, IGetMass
    {
        private double densityOfMaterial;

        public double DensityOfMaterial { get => densityOfMaterial; set => densityOfMaterial = value; }

        protected Container() { }
        public Container(TypeOfTransportation typeOfTransportation, double width, double length, double height, double tara, double densityOfMaterial) : base(typeOfTransportation, width, length, height, tara)
        {
            this.densityOfMaterial = densityOfMaterial;
        }  

        public override double GetVolume()
        {
            return (Width * Length * Height);
        }

        public override string ToString()
        {
            return String.Format("{0} -> Width = {1} m;Length = {2} m;Height = {3} m;Volume = {4} m^3;Tara = {5} kg;Density of material = {6} kg/m^3;Mass = {7} kg;", GetType().Name,Width, Length, Height, Math.Round(GetVolume(), 1), Tara, densityOfMaterial, Math.Round(GetMass(), 1));
        }

        public double GetMass()
        {
            return (densityOfMaterial * GetVolume() + Tara);
        }
    }
}
