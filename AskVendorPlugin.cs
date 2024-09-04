using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Plugin.Widgets.AskVendor.Components;
using Nop.Services.Cms;
using Nop.Services.Plugins;
using Nop.Web.Framework.Infrastructure;

namespace Nop.Plugin.Widgets.AskVendor
{
    public class AskVendorPlugin : BasePlugin, IWidgetPlugin
    {
        public bool HideInWidgetList => false; //gorunur hale getırdık widgeti true ise gorunmez hal!

        public Type GetWidgetViewComponent(string widgetZone)
        { //hangi widget gosterılcek

            
            return typeof(AskVendorViewComponent);

        }

        public async Task<IList<string>> GetWidgetZonesAsync()
        { //nerde gosterilecek

            var widgetZones = new List<string> { PublicWidgetZones.ProductDetailsInsideOverviewButtonsAfter }; 
            /* ılk once vendor before vendor after olusturup bu mantıkla tek defa tıklama yaratmıstım bunu degıstırdım kendı halınde calısıyor olması ıcın*/

            return await Task.FromResult(widgetZones);
        }
    }
}
