using FluentMigrator;
using Nop.Data.Extensions;
using Nop.Data.Migrations;
using Nop.Plugin.Widgets.HeaderSliderPlugin.Domain;

namespace Nop.Plugin.Widgets.HeaderSliderPlugin.Data
{
    [NopMigration("2020/12/07 09:30:17:6455422", ".Widgets.HeaderSliderPlugin base schema", MigrationProcessType.Installation)]
    public class SchemaMigration : AutoReversingMigration
    {
        public override void Up()
        {
            Create.TableFor<SlidingText>();
        }
    }
}