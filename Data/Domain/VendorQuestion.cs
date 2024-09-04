using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Core;

namespace Nop.Plugin.Widgets.AskVendor.Data.Domain;
public class VendorQuestion : BaseEntity
{
    /*
     kim sordu kime soruldu ne icin sorularını tutucam burada
    customerıd vendorıd productıd
     */

    public int CustomerId { get; set; }
    public int VendorId { get; set; }
    public int ProductId { get; set; }
    public string Question { get; set; }
    public DateTime CreatedOnUtc { get; set; } = DateTime.UtcNow;

}
