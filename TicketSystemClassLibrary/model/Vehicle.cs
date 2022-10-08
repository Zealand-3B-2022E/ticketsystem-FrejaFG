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

        public string Licenseplate
        {
            get;
            set;
        }
        public DateTime Date
        {
            get;
            set;
        }

        public abstract double Price
        {
            get;
            set;
        }


    }
}
