using Fb.Interfaces;
using Fb.TypeOfCargo;
using System;
using System.Collections.Generic;

namespace Fb
{
    class CargoComparer : Comparer<IGetMass>
    {
        public override int Compare(IGetMass x, IGetMass y)
        {
            if (x.GetType().Name.Equals(y.GetType().Name))
            {
                return 1 * (x.GetMass().CompareTo(y.GetMass()));
            }
            else
            {
                int index1 = (int)Enum.Parse(typeof(TypeOfTransportation), x.GetType().Name);
                int index2 = (int)Enum.Parse(typeof(TypeOfTransportation), y.GetType().Name);
                return (index1.CompareTo(index2));
            }
        }
    }
}
