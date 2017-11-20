namespace Fb.TypeOfCargo
{
    class StandartTank : Tank
    {
        public StandartTank(double densityOfMaterial)
        {
            TypeOfTransportation = TypeOfTransportation.Tank;
            Width = 4;
            Length = 5;
            Height = 3.5;
            Tara = 2000;
            DensityOfMaterial = densityOfMaterial;
        }
    }
}
