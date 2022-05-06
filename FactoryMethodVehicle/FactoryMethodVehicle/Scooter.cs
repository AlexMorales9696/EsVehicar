namespace FactoryMethodVehicle
{
    public class Scooter : Vehicle, IVehicle
    {
        public Scooter(int cilindrata) : base(cilindrata)
        {
        }
    }
}