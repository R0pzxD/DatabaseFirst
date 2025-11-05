using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
     public class Pilots
    {
        public ICollection<Planes> Planes { get; set; }
        [Key]
        public Guid PilotID { get; set; }
        public string PilotName { get; set; }
        public int FlightHours { get; set; }
        public DateTime LicenseExpiryDate { get; set; }
    }
}
