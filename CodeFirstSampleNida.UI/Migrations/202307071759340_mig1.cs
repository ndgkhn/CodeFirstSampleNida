namespace CodeFirstSampleNida.UI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomerEmployee1",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false),
                        CustomerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.EmployeeID, t.CustomerID })
                .ForeignKey("dbo.Customers", t => t.CustomerID, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.EmployeeID, cascadeDelete: true)
                .Index(t => t.EmployeeID)
                .Index(t => t.CustomerID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Address = c.String(),
                        Phone = c.String(maxLength: 20),
                        Aktifmi = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerID);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Branch = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CustomerEmployee1", "EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.CustomerEmployee1", "CustomerID", "dbo.Customers");
            DropIndex("dbo.CustomerEmployee1", new[] { "CustomerID" });
            DropIndex("dbo.CustomerEmployee1", new[] { "EmployeeID" });
            DropTable("dbo.Employees");
            DropTable("dbo.Customers");
            DropTable("dbo.CustomerEmployee1");
        }
    }
}
