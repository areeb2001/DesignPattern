using System;

namespace BuilderPattern
{
    public class AirPlane
    {
        private string Customer;
        private string Type;
        private string Avionics;
        private string powerPlant;
        private float wingsSpan;
        private int crewseats;
        private int Passengerseats;
        public AirPlane(string cus, string typ)
        {
            this.Customer = cus;
            this.Type = typ;
        }
        public void Setwingspan(float wings)
        {
            this.wingsSpan = wings;
        }
        public void SetPowerPlants(string powerp)
        {
            this.powerPlant = powerp;
        }
        public void setAvionics(string AV)
        {
            Avionics = AV;
        }
        public string GetCutsomer()
        {
            return Customer;
        }
        public String Gettype()
        {
            return Type;
        }
        public void SetNumberSeats(int creaw, int Pass)
        {
            crewseats = creaw;
            Passengerseats = Pass;
        }
    }
    public abstract class AirPlaneBuilder
    {
        protected AirPlane airplane;
        protected String customer;
        protected string type;
        public AirPlaneBuilder(string cus)
        {
            customer = cus;
        }
        public AirPlane getAirplane()
        {
            return airplane;
        }
        public void CreateAirplane()
        {
            airplane = new AirPlane(customer, type);
        }
        public abstract void BuildWings();
        public abstract void BuildPowerplants();
        public abstract void BuildAvionics();
        public abstract void BuildSeats();
    }
    public class CropDuster : AirPlaneBuilder
    {
        public CropDuster(string Cus) : base(Cus)
        {
            base.customer = customer;
            base.type = "Crop Duster";
        }
        public override void BuildWings()
        {
            airplane.Setwingspan(9f);
        }
        public override void BuildPowerplants()
        {
            airplane.SetPowerPlants("Single Piston");
        }
        public override void BuildAvionics(){ }
        public override void BuildSeats()
        {
            airplane.SetNumberSeats(1, 1);
        }
    }
    public class AerospaceEngineer
    {
        private AirPlaneBuilder airplanebuilder;
        public void SetAirplanceBuilder(AirPlaneBuilder Av)
        {
            this.airplanebuilder = Av;
        }
        public AirPlane GetAirPlane()
        {
            return airplanebuilder.getAirplane();
        }
        public void ConstructAirplane()
        {
            airplanebuilder.CreateAirplane();
            airplanebuilder.BuildWings();
            airplanebuilder.BuildSeats();
            airplanebuilder.BuildPowerplants();
            airplanebuilder.BuildAvionics();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AerospaceEngineer aero = new AerospaceEngineer();
            AirPlaneBuilder Crop = new CropDuster("Muhammad Areeb");
            aero.SetAirplanceBuilder(Crop);
            aero.ConstructAirplane();
            AirPlane ae = aero.GetAirPlane();
            Console.WriteLine(ae.Gettype() + " is redy for customer " + ae.GetCutsomer());
        }
    }
}

