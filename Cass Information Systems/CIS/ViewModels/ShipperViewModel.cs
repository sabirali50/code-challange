using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS.SharedKernel.ViewModels
{
    public class ShipperViewModel
    {
        public int ShipperId { get; set; }
        public string ShipperName { get; set; }
    }
}
