using Fb.Interfaces;

namespace Fb.TypeOfCargo
{
    class StandartContainer : Container, IGetMass
    {
        public StandartContainer(double densityOfMaterial)
        {
            TypeOfTransportation = TypeOfTransportation.Container;
            Width = 2;
            Length = 4;
            Height = 2.5;
            Tara = 1500;
            DensityOfMaterial = densityOfMaterial;
        }       
    }
}
