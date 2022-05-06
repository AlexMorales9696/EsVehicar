namespace FactoryMethodVehicle
{
    public class Car : Vehicle, IVehicle
    {
        public Car(int cilindrata) : base(cilindrata)
        {
        }
    }
}
