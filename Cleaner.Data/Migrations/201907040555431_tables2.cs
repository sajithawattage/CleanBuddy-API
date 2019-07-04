namespace Cleaner.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tables2 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.JobEquipments", "JobID");
            AddForeignKey("dbo.JobEquipments", "JobID", "dbo.Jobs", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.JobEquipments", "JobID", "dbo.Jobs");
            DropIndex("dbo.JobEquipments", new[] { "JobID" });
        }
    }
}
