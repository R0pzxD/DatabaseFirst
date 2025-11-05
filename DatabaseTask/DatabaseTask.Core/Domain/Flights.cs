using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Flights 
    {
        [Key]
        public Guid FlightID { get; set; }
        public Guid passengerID { get; set; }
        public string Destination { get; set; }
        public Guid PlaneID { get; set; }
        public DateTime? FlightDate { get; set; }
        

    }
}
