using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSI.Core.Models
{
    [Keyless]
    public class ShipmentDetail
    {
        [JsonProperty("shipmentId")]
        public int shipment_id { get; set; }

        [JsonProperty("shipperName")]
        public string shipper_name { get; set; }

        [JsonProperty("carrierName")]
        public string carrier_name { get; set; }

        [JsonProperty("shipmentDescription")]
        public string shipment_description { get; set; }

        [JsonProperty("shipmentWeight")]
        public decimal shipment_weight { get; set; }

        [JsonProperty("shipmentRateDescription")]
        public string shipment_rate_description { get; set; }

    }
}
