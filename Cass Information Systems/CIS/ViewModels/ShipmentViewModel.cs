using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS.SharedKernel.ViewModels
{
    public class ShipmentViewModel
    {
        public int ShipmentId { get; set; }
        public int ShipperId { get; set; }
        public string ShipmentDescription { get; set; }
        public decimal ShipmentWeight { get; set; }
        public int ShipmentRateId { get; set; }
        public int CarrierId { get; set; }

        public ShipperViewModel Shipper { get; set; }
        public ShipmentRateViewModel ShipmentRate { get; set; }
        public CarrierViewModel Carrier { get; set; }
    }
}
