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
        public override double Price { get => mcPrice; set => mcPrice = value; }
        public override string VehicleType { get => _vehicleType; set => _vehicleType = value; }

        public double mcPrice;
        private string? _vehicleType;

        // methods
        public double MCPrice(double mcPrice)
        {
            mcPrice = 125.0;
            return mcPrice;
        }

        public string VehicleTypeMC(string MC)
        {
            VehicleType = MC;
            return VehicleType;
        }


        public override string ToString()
        {
            return $" {nameof(Price)}: {Price} {nameof(VehicleType)}: {VehicleType} ";
        }
    }
}
