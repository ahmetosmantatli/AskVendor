using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nop.Services.Cms;
using Nop.Web.Framework.Components;
using Nop.Web.Models.Catalog;

namespace Nop.Plugin.Widgets.AskVendor.Components;
public class AskVendorViewComponent : NopViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync(string widgetZone , object additionalData) 
    {
        /* if (widgetZone != "VendorAfter")
            return Content("");  // boş dondurucek eger daha once yazdıysam */

        if (additionalData is not ProductDetailsModel)
            return Content("");       //


        var model = (ProductDetailsModel)additionalData;

        //breakpoint koydum vendormodel null donmuyor var oldugu ıcın id kontrolu yapıcaz bu yuzden! bu sayede vendor koymadıgım urunde ask vendor cıkamaz..
        if (model.VendorModel.Id<=0)
            return Content("");


        return await Task.FromResult(View("~/Plugins/Widgets.AskVendor/Views/AskVendor.cshtml"));
    }

}
