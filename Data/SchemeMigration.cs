using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator;
using Nop.Data.Extensions;
using Nop.Data.Migrations;
using Nop.Plugin.Widgets.AskVendor.Data.Domain;

namespace Nop.Plugin.Widgets.AskVendor.Data;


[NopMigration("2024-04-12 10:20:20:6544156", "Ask Vendor Installation Migrate", MigrationProcessType.Installation)]
public class SchemeMigration : AutoReversingMigration
{
    
    public override void Up()
    {
        Create.TableFor<VendorQuestion>();
    }
}
