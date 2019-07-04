namespace Cleaner.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tables3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.JobEquipments", "JobID", "dbo.Jobs");
            DropIndex("dbo.JobEquipments", new[] { "JobID" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.JobEquipments", "JobID");
            AddForeignKey("dbo.JobEquipments", "JobID", "dbo.Jobs", "Id", cascadeDelete: true);
        }
    }
}
