using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator.Builders.Create.Table;
using Nop.Core.Domain.Vendors;
using Nop.Data.Mapping.Builders;
using Nop.Plugin.Widgets.AskVendor.Data.Domain;
using Nop.Data.Extensions;
using Nop.Core.Domain.Customers;
using Nop.Core.Domain.Catalog;

namespace Nop.Plugin.Widgets.AskVendor.Data.Builders;
public class VendorQuestionBuilder : NopEntityBuilder<VendorQuestion>
{
    public override void MapEntity(CreateTableExpressionBuilder table)
    {
       /* unistall mı kontrol edıcem degılse unistall ardından yıldızı kaldırıp tekrar install database de tabloyu boyle yapıcam..
        * table.
            WithColumn(nameof(VendorQuestion.CustomerId)).AsInt32().ForeignKey<Customer>().
            WithColumn(nameof(VendorQuestion.Question)).AsString().NotNullable().
            WithColumn(nameof(VendorQuestion.VendorId)).AsInt32().ForeignKey<Vendor>().
            WithColumn(nameof(VendorQuestion.ProductId)).AsInt32().ForeignKey<Product>().
            WithColumn(nameof(VendorQuestion.CreatedOnUtc)).AsDateTime2().NotNullable (); */

    }
}
