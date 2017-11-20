using Fb.Interfaces;

namespace Fb
{
    class Ferryboat
    {
        public const double Сapacity = 100_000;
        IGetMass[] arr;

        internal IGetMass[] Arr { get => arr; set => arr = value; }

        public Ferryboat(IGetMass[] arr)
        {
            this.arr = arr;
        }        
    }
}
