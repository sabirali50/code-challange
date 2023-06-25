using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS.SharedKernel.ViewModels
{
    public class CarrierViewModel
    {
        public int CarrierId { get; set; }
        public string CarrierName { get; set; }
        public string CarrierMode { get; set; }
    }
}
