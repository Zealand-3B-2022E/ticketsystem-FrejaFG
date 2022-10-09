﻿using TicketSystemClassLibrary.model;

namespace StoreBaelt
{
    public class StoreBaeltPrice : Vehicle
    {
        private double _discount = 1.0;
        private double _weekendDiscount = 0.8;
        private DayOfWeek _dayOfWeek;
        public override bool BroBizz 
        {
            get => BroBizz;
            set => BroBizz = value;
        }
        
        public override string VehicleType 
        { 
            get => VehicleType;
            set => VehicleType = value;
        }
        public override double Price
        {
            get => Price;
            set => Price=value;
        }

        public double Discount
        {
            get => _discount;
            set=> _discount = value;
        }
        public new DateTime Date
        {
            get => Date;
            set => Date = value;
        }
        public DayOfWeek GetDayOfWeek
        {
            get => _dayOfWeek;
            set => _dayOfWeek = value;
        }

        public double BroBizzDiscount
        {
            get => _discount;
            set
            {
                SetBroBizzDiscpunt(value);
                BroBizzDiscount = value;
            }
        }
        public double WeekendPris
        {
            get => _weekendDiscount;
            set
            {
                _weekendDiscount = value;
            }

        }
        /// <summary>
        /// Empty constructor for test
        /// </summary>
        public StoreBaeltPrice()
        {

        }
        public StoreBaeltPrice(double discount, bool broBizz, string vehicleType, double price, DateTime date)
        {
            _discount = discount;
            BroBizz = broBizz;
            VehicleType = vehicleType;
            Price = price;
            Date = date;
        }

        public override string ToString()
        {
            return $" {nameof(BroBizz)} : {BroBizz} - Dag: {GetDayOfWeek} - {nameof(Discount)}: {string.Format("{0:P}", 1.0-Discount)} - Køretøj: {VehicleType} - {nameof(Price)}: {Price}";
        }

        private void SetBroBizzDiscpunt(double broBizzDiscount)
        {
            if (BroBizz == true)
            {
                broBizzDiscount = 0.95;
            }

            else 
            {
                broBizzDiscount = 1.0;
            }
        }

        private void SetWeekendDiscount( double weekendDiscount, DayOfWeek dayOfWeek)
        {
            if(dayOfWeek == DayOfWeek.Saturday || dayOfWeek==DayOfWeek.Sunday)
            {
                 weekendDiscount = 0.8;
            }
            else
            {
                 weekendDiscount = 1.0;
            }
        }

        private void SetWeekendDiscount(double weekendDiscount)
        {
            
        }
        private void SetPrice(double StorebaeltPrice)
        {
            if(VehicleType=="MC")
            {
                StorebaeltPrice = 125.0;
            }
            if(VehicleType=="Car")
            {
                StorebaeltPrice = 240.0;//Kan jeg hente CarPRice?
            }

            if(BroBizz==false) // and statement??
            {
                StorebaeltPrice = StorebaeltPrice * BroBizzDiscount*WeekendPris;
            }


        }
    }
}