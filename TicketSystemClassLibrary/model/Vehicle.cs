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


        public Vehicle()
        {
            //Licenseplate = "1234567";
            //Date = DateTime.Now;
            //Price = 240.0;
            //VehicleType = "Car";
        }
        public Vehicle(string licenseplate, DateTime date, double price, string vehicleType)
        {
            Licenseplate = licenseplate;
            Date = date;
            Price = price;
            VehicleType = vehicleType;
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
            get;set;
        }

        public override string ToString()
        {
            return $" {nameof(Licenseplate)}: {Licenseplate} - {nameof(Date)}: {Date} - {nameof(Price)}: {Price}";
        }

        private void CheckLicense(string licenseplate)
        {
            if (string.IsNullOrWhiteSpace(licenseplate))
            {
                throw new ArgumentNullException("Nummerplade er påkrævet");
            }
            if (7 < licenseplate.Length)
            {
                throw new ArgumentException("Nummerpladen må ikke indeholde mere end 7 karakterer.");
            }
        }

    }
}
