using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary.model
{
    public abstract class Vehicle
    {
        // The class is abstract. it only exists when a spicifick instance is created

        private string _licenseplate="";
        private DateTime _date;
        private double _price;
        private string _vehicleType;
        private bool _broBizz;


        public Vehicle()
        {
            
        }
        public Vehicle(string licenseplate, DateTime date, double price, string vehicleType, bool broBizz)
        {
            Licenseplate = licenseplate;
            Date = date;
            Price = price;
            VehicleType = vehicleType;
            BroBizz = broBizz;
        }

        public abstract bool BroBizz
        {
            get;
            set; 
        }

        public string Licenseplate
        {
            get=>_licenseplate;
            set=>_licenseplate=value;
        }
        public DateTime Date
        {
            get=>_date;
            set=>_date=value;
        }

        public abstract double Price
        {
            get; // No 'get-set' here 
            set; // Because it is abstract!
        }

        public abstract string VehicleType
        {
            get;
            set;
        }

        public override string ToString()
        {
            return $" {nameof(Licenseplate)}: {Licenseplate} - {nameof(Date)}: {Date} - {nameof(Price)}: {Price} - Har en{nameof(BroBizz)}: {BroBizz}";
        }

    }
}
