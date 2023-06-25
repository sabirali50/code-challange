using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSI.Core.Models
{
    [Table("SHIPPER")]
    public class Shipper 
    {
        [Column("shipper_id")]
        public int ShipperId { get; set; }
        [Column("shipper_name")]
        public string ShipperName { get; set; }
    }
}
