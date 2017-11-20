using Fb.Interfaces;

namespace Fb.TypeOfCargo
{
    class StandartPerson : Person, IGetMass
    {
        public StandartPerson()
        {
            Mass = 70;
        }

        double IGetMass.GetMass()
        {
            return Mass;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
