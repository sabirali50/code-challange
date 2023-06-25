using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSI.Core.Models
{
    [Table("CARRIER")]
    public class Carrier
    {
        [Column("carrier_id")]
        public int CarrierId { get; set; }
        [Column("carrier_name")]
        public string CarrierName { get; set; }
        [Column("carrier_mode")]
        public string CarrierMode { get; set; }

    }
}
