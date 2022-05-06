namespace FactoryMethodVehicle
{
    public abstract class Vehicle : IVehicle
    {
        public int Cilindrata;

        public Vehicle(int cilindrata) => Cilindrata = cilindrata;

        public int GetPower() => Cilindrata;

    }
}
