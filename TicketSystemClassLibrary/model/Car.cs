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
        private string? _vehicleType;

        public string LicenseplateCar
        {
            get => Licenseplate;
            set
            {
                CheckLicenseplate(value);
                Licenseplate = value;
            }
        }

        public override string VehicleType { get => _vehicleType;
            set =>_vehicleType=value; }
        public override bool BroBizz { get => BroBizz; set => BroBizz=value; }

        public Car()
        {
            // Keep This Constructor!!
            //Unit tests needs them!
        }
        public Car(string licenseplate, DateTime date, double price, string vehicleType)
        {
            LicenseplateCar = licenseplate;
            Date = date;
            Price = price;
            VehicleType = vehicleType;
        }

        // methods

        /// <summary>
        /// Metode til at bestemme prisen for en bil
        /// </summary>
        /// <param name="carPrice"></param>
        /// <returns></returns>
        public double CarPrice(double carPrice)
        {
            if (BroBizz = false)
            {
                carPrice = 240.0;
            }
            if (BroBizz = true)
            {
                carPrice = 228.0;
            }
            return carPrice;
        }

        public string VehicleTypeCar(string Car)
        {
            VehicleType = Car;
            return VehicleType;
        }

        public override string ToString()
        {
            return $" {nameof(Licenseplate)}: {Licenseplate} {nameof(Date)}: {Date} {nameof(CarPrice)}: {CarPrice} {nameof(VehicleType)}: {VehicleType} ";
        }

        private void CheckLicenseplate(string licenseplate)
        {
            if (licenseplate.Length < 1 || licenseplate.Length > 7)
            {
                throw new ArgumentException("Nummerplade må maks indeholde 7 tegn");
            }
        }
    }
}
