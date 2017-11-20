using Fb.Interfaces;

namespace Fb.TypeOfCargo
{
    class StandartCargo : Cargo, IGetMass
    {
        public StandartCargo()
        {
            MassCargo = 100;
        }
    }
}
