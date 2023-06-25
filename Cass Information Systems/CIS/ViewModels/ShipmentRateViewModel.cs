using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS.SharedKernel.ViewModels
{
    public class ShipmentRateViewModel
    {
        public int ShipmentRateId { get; set; }
        public string ShipmentRateClass { get; set; }
        public string ShipmentRateDescription { get; set; }
    }
}
