using Fb.Factories;
using Fb.Interfaces;
using System;
using Fb.TypeOfCargo;

namespace Fb
{
    class Program
    {
        static void Main(string[] args)
        {
            IGetMass[] arr =
            {
                CargoFactory.GetTypeOfCargoTransportation(TypeOfTransportation.Container, 1, 2, 3, 400, 5),
                CargoFactory.GetTypeOfCargoTransportation(TypeOfTransportation.Container, 3, 5, 7, 600, 50),
                CargoFactory.GetTypeOfCargoTransportation(TypeOfTransportation.StandartContainer, 100),
                CargoFactory.GetTypeOfCargoTransportation(TypeOfTransportation.Tank, 1, 2, 3, 400, 5),
                CargoFactory.GetTypeOfCargoTransportation(TypeOfTransportation.Tank, 3, 4, 2, 700, 500),
                CargoFactory.GetTypeOfCargoTransportation(TypeOfTransportation.StandartTank, 330),
                CargoFactory.GetTypeOfCargoTransportation(TypeOfTransportation.Cargo, 150),
                CargoFactory.GetTypeOfCargoTransportation(TypeOfTransportation.Cargo, 450),
                CargoFactory.GetTypeOfCargoTransportation(TypeOfTransportation.StandartCargo),
                CargoFactory.GetTypeOfCargoTransportation(TypeOfTransportation.Person, 60),
                CargoFactory.GetTypeOfCargoTransportation(TypeOfTransportation.Person, 80),
                CargoFactory.GetTypeOfCargoTransportation(TypeOfTransportation.StandartPerson)
            };

            Ferryboat ferryboat = new Ferryboat(arr);

            foreach (var item in ferryboat.Arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Array.Sort(arr, new CargoComparer());
            foreach (var item in ferryboat.Arr)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
    }
}
