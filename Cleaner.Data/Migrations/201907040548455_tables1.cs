namespace Cleaner.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tables1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Addresses", "UpdateDate", c => c.DateTime());
            AlterColumn("dbo.ApproveGroups", "UpdateDate", c => c.DateTime());
            AlterColumn("dbo.Contractors", "UpdateDate", c => c.DateTime());
            AlterColumn("dbo.ContractorEmployees", "UpdateDate", c => c.DateTime());
            AlterColumn("dbo.Employees", "UpdateDate", c => c.DateTime());
            AlterColumn("dbo.Equipments", "UpdateDate", c => c.DateTime());
            AlterColumn("dbo.EquipmentCategories", "UpdateDate", c => c.DateTime());
            AlterColumn("dbo.Jobs", "UpdateDate", c => c.DateTime());
            AlterColumn("dbo.JobEquipments", "UpdateDate", c => c.DateTime());
            AlterColumn("dbo.RequestHeaders", "UpdateDate", c => c.DateTime());
            AlterColumn("dbo.Sites", "UpdateDate", c => c.DateTime());
            AlterColumn("dbo.SiteSubContractors", "UpdateDate", c => c.DateTime());
            AlterColumn("dbo.SubContractors", "UpdateDate", c => c.DateTime());
            AlterColumn("dbo.UserAccounts", "UpdateDate", c => c.DateTime());
            AlterColumn("dbo.WorkTypes", "UpdateDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.WorkTypes", "UpdateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.UserAccounts", "UpdateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.SubContractors", "UpdateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.SiteSubContractors", "UpdateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Sites", "UpdateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.RequestHeaders", "UpdateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.JobEquipments", "UpdateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Jobs", "UpdateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.EquipmentCategories", "UpdateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Equipments", "UpdateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Employees", "UpdateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ContractorEmployees", "UpdateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Contractors", "UpdateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ApproveGroups", "UpdateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Addresses", "UpdateDate", c => c.DateTime(nullable: false));
        }
    }
}
