namespace FactoryMethodVehicle
{
    public class Truck : Vehicle, IVehicle
    {
        public Truck(int cilindrata) : base(cilindrata)
        {
        }
    }
}
