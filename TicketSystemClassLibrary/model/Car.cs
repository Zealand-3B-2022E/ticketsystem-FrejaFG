using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary.model
{
    public class Car
    {

        // Properties
        public string LicensePlate { get; set; }
        public DateTime Date { get; set; }
        public double price;

        // methods
        public double Price(double price)
        {
            //Price = 240.0;
            return 240.00;
        }

        public string VehicleType(string Car)
        {
            return Car;
        }

        public override string ToString()
        {
            return $" {nameof(Price)}: {Price} ";
        }
    }
}
