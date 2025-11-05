using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
     public class Tickets
    {
        public ICollection<Flights> Flights { get; set; }
        public ICollection<passengers> passengers { get; set; }
        [Key]
        public Guid TicketID { get; set; }
        public Guid passengerID { get; set; }
        public Guid FlightID { get; set; }
        
        public int Price { get; set; }

        public int SeatNumber { get; set; }
        public DateTime DateOFBooking { get; set; }
    }
}
