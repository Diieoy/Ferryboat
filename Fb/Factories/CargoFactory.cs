using Fb.Interfaces;
using Fb.TypeOfCargo;
using System;

namespace Fb.Factories
{
    class CargoFactory
    {
        public static IGetMass GetTypeOfCargoTransportation(TypeOfTransportation typeOfTransportation, params double[] parametersOfTheSelectedType)
        {
            switch (typeOfTransportation)
            {
                case TypeOfTransportation.Cargo:
                    return new Cargo(parametersOfTheSelectedType[0]);
                case TypeOfTransportation.StandartCargo:
                    return new StandartCargo();
                case TypeOfTransportation.Container:
                    return new Container(typeOfTransportation, parametersOfTheSelectedType[0], parametersOfTheSelectedType[1], parametersOfTheSelectedType[2], parametersOfTheSelectedType[3], parametersOfTheSelectedType[4]);
                case TypeOfTransportation.StandartContainer:
                    return new StandartContainer(parametersOfTheSelectedType[0]);
                case TypeOfTransportation.Tank:
                    return new Tank(typeOfTransportation, parametersOfTheSelectedType[0], parametersOfTheSelectedType[1], parametersOfTheSelectedType[2], parametersOfTheSelectedType[3], parametersOfTheSelectedType[4]);
                case TypeOfTransportation.StandartTank:
                    return new StandartTank(parametersOfTheSelectedType[0]);
                case TypeOfTransportation.Person:
                    return new Person(parametersOfTheSelectedType[0]);
                case TypeOfTransportation.StandartPerson:
                    return new StandartPerson();
                default:
                    throw new Exception("Wrong type");                
            }
        }
    }
}
