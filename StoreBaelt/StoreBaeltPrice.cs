using TicketSystemClassLibrary.model;

namespace StoreBaelt
{
    public class StoreBaeltPrice : Vehicle
    {
        private double _discount = 1.0;
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


    }
}