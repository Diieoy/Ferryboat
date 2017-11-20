using Fb.Interfaces;
using System;

namespace Fb.TypeOfCargo
{
    class Cargo : AbstractPlatformForCargo, IGetMass
    {
        protected Cargo() {}
        public Cargo(double massCargo)
        {
            MassCargo = massCargo;
        }

        public override string ToString()
        {
            return String.Format("{0} -> Mass cargo = {1} kg",GetType().Name, MassCargo);
        }
    }
}
