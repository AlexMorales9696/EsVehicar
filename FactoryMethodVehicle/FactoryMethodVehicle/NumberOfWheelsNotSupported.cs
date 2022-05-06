using System;

namespace FactoryMethodVehicle
{
    [Serializable]
    internal class NumberOfWheelsNotSupported : Exception
    {
        public NumberOfWheelsNotSupported()
        {
        }

        public NumberOfWheelsNotSupported(string message) : base(message)
        {
        }
    }
}