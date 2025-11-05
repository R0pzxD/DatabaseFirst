using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Planes
    {
        public ICollection<Flights> Flights { get; set; }
        [Key]
        public Guid PlaneID { get; set; }
        public int registrationNumber { get; set; }
        public int Model {  get; set; }
        public string manufacturer { get; set; }
        public int SeatCapacity { get; set; }


    }
}
