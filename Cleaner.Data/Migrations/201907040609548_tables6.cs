namespace Cleaner.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tables6 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.JobEquipments", "JobID", "dbo.Jobs");
            DropIndex("dbo.JobEquipments", new[] { "JobID" });
            AlterColumn("dbo.JobEquipments", "JobID", c => c.Int());
            CreateIndex("dbo.JobEquipments", "JobID");
            AddForeignKey("dbo.JobEquipments", "JobID", "dbo.Jobs", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.JobEquipments", "JobID", "dbo.Jobs");
            DropIndex("dbo.JobEquipments", new[] { "JobID" });
            AlterColumn("dbo.JobEquipments", "JobID", c => c.Int(nullable: false));
            CreateIndex("dbo.JobEquipments", "JobID");
            AddForeignKey("dbo.JobEquipments", "JobID", "dbo.Jobs", "Id", cascadeDelete: true);
        }
    }
}
