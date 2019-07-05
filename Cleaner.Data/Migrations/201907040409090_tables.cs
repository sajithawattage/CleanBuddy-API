namespace Cleaner.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        StreetAddress = c.String(),
                        State = c.String(),
                        City = c.String(),
                        PostalCode = c.Int(nullable: false),
                        Country = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ApproveGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GroupName = c.String(),
                        Description = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Contractors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AddressID = c.Int(nullable: false),
                        Name = c.String(),
                        EmailID = c.String(),
                        ContactPerson = c.String(),
                        ContactNo = c.Int(nullable: false),
                        ABN = c.String(),
                        PaymentOption = c.Int(nullable: false),
                        InvoiceDate = c.DateTime(nullable: false),
                        Note = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ContractorEmployees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeJobID = c.Int(nullable: false),
                        ContractorID = c.Int(nullable: false),
                        EmployeeID = c.Int(nullable: false),
                        JoinDate = c.DateTime(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeName = c.String(),
                        EmployeeContactNo = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Equipments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Brand = c.String(),
                        Model = c.String(),
                        CategoryID = c.Int(nullable: false),
                        PurchasedFrom = c.String(),
                        PurchaseDate = c.DateTime(nullable: false),
                        WarrantyExpire = c.DateTime(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EquipmentCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Jobs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SiteID = c.Int(nullable: false),
                        JobStartDate = c.DateTime(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.JobEquipments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        JobID = c.Int(nullable: false),
                        EquipmentID = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RequestHeaders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RequestID = c.Int(nullable: false),
                        GroupID = c.Int(nullable: false),
                        EmployeeID = c.Int(nullable: false),
                        JobID = c.Int(nullable: false),
                        RequestDateTime = c.DateTime(nullable: false),
                        ApproveGroupID = c.Int(nullable: false),
                        ApproveStatus = c.String(),
                        ApprovedDateTime = c.DateTime(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sites",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WorkTypeID = c.Int(nullable: false),
                        AddressID = c.Int(nullable: false),
                        ContractorID = c.Int(nullable: false),
                        SiteName = c.String(),
                        WorkType = c.Int(nullable: false),
                        Notes = c.String(),
                        Budget = c.Int(nullable: false),
                        Allocation = c.Int(nullable: false),
                        WorkDays = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SiteSubContractors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SubContractorID = c.Int(nullable: false),
                        ReportingOfficer = c.String(),
                        SiteID = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SubContractors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ContractorID = c.Int(nullable: false),
                        Name = c.String(),
                        AddressID = c.Int(nullable: false),
                        ABN = c.String(),
                        EmailAddress = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserAccounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        PasswordHash = c.String(),
                        UserRoleID = c.Int(nullable: false),
                        EmployeeID = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WorkTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WorkTypeName = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WorkTypes");
            DropTable("dbo.UserAccounts");
            DropTable("dbo.SubContractors");
            DropTable("dbo.SiteSubContractors");
            DropTable("dbo.Sites");
            DropTable("dbo.RequestHeaders");
            DropTable("dbo.JobEquipments");
            DropTable("dbo.Jobs");
            DropTable("dbo.EquipmentCategories");
            DropTable("dbo.Equipments");
            DropTable("dbo.Employees");
            DropTable("dbo.ContractorEmployees");
            DropTable("dbo.Contractors");
            DropTable("dbo.ApproveGroups");
            DropTable("dbo.Addresses");
        }
    }
}
