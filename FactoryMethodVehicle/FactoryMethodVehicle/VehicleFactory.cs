namespace FactoryMethodVehicle
{
    public class VehicleFactory
    {
        public static IVehicle Build(int numberOfWheels, int cilindrata,double peso) => numberOfWheels switch
        {
            2 => cilindrata > 125 ? new Motorbike(cilindrata) : new Scooter(cilindrata),
            3 => new Sidecar(cilindrata),
            4 => new Car(cilindrata),
            6 => peso >1900 ?new Tir(cilindrata): new Truck(cilindrata),
            _ => throw new NumberOfWheelsNotSupported()
        };
    }
}
