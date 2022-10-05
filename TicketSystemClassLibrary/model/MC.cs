using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary.model
{
    public class MC
    {
        // Properties
        public string LicensePlate { get; set; }
        public DateTime Date { get; set; }
        public double price;
        public string Vehicle;

        // methods
        public double Price(double price)
        {
            //Price = 125.0;
            return 125.00;
        }

        public string VehicleType(string MC)
        {
            Vehicle = MC;
            return Vehicle;
        }


        public override string ToString()
        {
            return $" {nameof(Price)}: {Price} {nameof(VehicleType)}: {VehicleType} ";
        }
    }
}
