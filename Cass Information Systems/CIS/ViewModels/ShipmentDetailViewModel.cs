using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS.SharedKernel.ViewModels
{
    public class ShipmentDetailViewModel
    {
        public int shipment_id { get; set; }
        public string shipper_name { get; set; }
        public string carrier_name { get; set; }
        public string shipment_description { get; set; }
        public decimal shipment_weight { get; set; }
        public string shipment_rate_description { get; set; }
    }
}
