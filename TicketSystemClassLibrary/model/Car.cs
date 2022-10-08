using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary.model
{
    public class Car:Vehicle
    {

        // Properties
        public string Licenseplate { get; set; }
        public DateTime Date { get; set; }
        public override double Price { get => carPrice; set => throw new NotImplementedException(); }

        public double carPrice;
        public string Vehicle;

        // methods
        public double CarPrice(double carPrice)
        {
            carPrice = 240.0;
            return carPrice;
        }

        public string VehicleType(string Car)
        {
            Vehicle = Car;
            return Vehicle;
        }

        public override string ToString()
        {
            return $" {nameof(Licenseplate)}: {Licenseplate} {nameof(Date)}: {Date} {nameof(CarPrice)}: {CarPrice} {nameof(VehicleType)}: {VehicleType} ";
        }
    }
}
