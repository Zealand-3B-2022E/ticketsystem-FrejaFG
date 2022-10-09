using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystemClassLibrary.model;

namespace OresundbronTicketLibrary
{
    public class OresundVehicle : Vehicle
    {
        public override bool BroBizz 
        {
            get => BroBizz;
            set => BroBizz = value;
        }
        public override double Price 
        {
            get => Price;
            set => Price = value;
        }
        public override string VehicleType 
        {
            get => VehicleType;
            set => VehicleType = value;
        }

        public OresundVehicle()
        {

        }
        public string OresundVehicleType(string oresundVehicleType)
        {
            if(VehicleType=="Car")
            {
                oresundVehicleType = "OresundCar";
            }
            if(VehicleType=="MC")
            {
                oresundVehicleType = "OresundMC";
            }
            return oresundVehicleType;
        }
    }
}
