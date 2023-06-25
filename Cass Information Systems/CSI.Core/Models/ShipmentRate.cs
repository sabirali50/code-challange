using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSI.Core.Models
{
    [Table("SHIPMENT_RATE")]
    public class ShipmentRate
    {
        [Column("shipment_rate_id")]
        public int ShipmentRateId { get; set; }
        [Column("shipment_rate_class")]
        public string ShipmentRateClass { get; set; }
        [Column("shipment_rate_description")]
        public string ShipmentRateDescription { get; set; }
    }
}
