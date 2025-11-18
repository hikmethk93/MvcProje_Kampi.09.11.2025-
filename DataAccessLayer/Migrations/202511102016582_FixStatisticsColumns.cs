namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixStatisticsColumns : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Statistics", "StatisticsValue", c => c.String());
            DropColumn("dbo.Statistics", "StatisticsValue3");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Statistics", "StatisticsValue3", c => c.String());
            AlterColumn("dbo.Statistics", "StatisticsValue", c => c.Int(nullable: false));
        }
    }
}
