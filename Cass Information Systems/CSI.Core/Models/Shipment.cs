using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSI.Core.Models
{
    [Table("SHIPMENT")]
    public class Shipment
    {
        [Column("shipment_id")]
        public int ShipmentId { get; set; }
        [Column("shipper_id")]
        public int ShipperId { get; set; }
        [Column("shipment_description")]
        public string ShipmentDescription { get; set; }
        [Column("shipment_weight")]
        public decimal ShipmentWeight { get; set; }
        [Column("shipment_rate_id")]
        public int ShipmentRateId { get; set; }
        [Column("carrier_id")]
        public int CarrierId { get; set; }

        // Navigation properties
        public Shipper Shipper { get; set; }
        public ShipmentRate ShipmentRate { get; set; }
        public Carrier Carrier { get; set; }
    }
}
