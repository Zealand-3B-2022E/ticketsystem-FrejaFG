using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary.model
{
    public class MC : Vehicle
    {
        // Properties
        public string LicensePlate { get; set; }
        public DateTime Date { get; set; }
        public /*override*/ double Price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public double mcPrice;
        public string Vehicle;

        // methods
        public double MCPrice(double mcPrice)
        {
            mcPrice = 125.0;
            return mcPrice;
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
