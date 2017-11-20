namespace Fb.TypeOfCargo
{
    enum TypeOfTransportation { StandartPerson, StandartContainer, StandartCargo, StandartTank, Person, Container, Cargo, Tank }

    abstract class AbstractTypeOfCargoTransportation
    {
        private TypeOfTransportation typeOfTransportation;        
        private double width;
        private double length;
        private double height;
        private double tara;

        internal TypeOfTransportation TypeOfTransportation { get => typeOfTransportation; set => typeOfTransportation = value; }
        public double Width { get => width; set => width = value; }
        public double Length { get => length; set => length = value; }
        public double Height { get => height; set => height = value; }       
        public double Tara { get => tara; set => tara = value; }

        protected AbstractTypeOfCargoTransportation() { }
        protected AbstractTypeOfCargoTransportation(TypeOfTransportation typeOfTransportation, double width, double length, double height, double tara)
        {
            this.typeOfTransportation = typeOfTransportation;
            this.width = width;
            this.length = length;
            this.height = height;
            this.tara = tara;
        }

        public abstract double GetVolume();
    }
}
