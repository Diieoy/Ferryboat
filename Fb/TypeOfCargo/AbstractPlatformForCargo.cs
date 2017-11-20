using Fb.Interfaces;

namespace Fb.TypeOfCargo
{
    abstract class AbstractPlatformForCargo : IGetMass
    {
        private double massCargo;

        public double MassCargo { get => massCargo; set => massCargo = value; }

        public double GetMass()
        {
            return massCargo;
        }       
    }
}
