namespace RastislavRuzbackyMojeCVmvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PacientModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Meno = c.String(),
                        DatumNarodenia = c.DateTime(nullable: false),
                        Pohlavie = c.String(),
                        RodneCislo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DiagnozaModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nazov = c.String(),
                        Popis = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GenetickeVysetrenieModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nazov = c.String(),
                        Vysledok = c.String(),
                        DatumVysetrenia = c.DateTime(),
                        PacientModelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PacientModels", t => t.PacientModelId, cascadeDelete: true)
                .Index(t => t.PacientModelId);
            
            CreateTable(
                "dbo.PriznakModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nazov = c.String(),
                        DatumZaznamenania = c.DateTime(),
                        PacientModelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PacientModels", t => t.PacientModelId, cascadeDelete: true)
                .Index(t => t.PacientModelId);
            
            CreateTable(
                "dbo.DiagnozaModelPacientModels",
                c => new
                    {
                        DiagnozaModel_Id = c.Int(nullable: false),
                        PacientModel_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.DiagnozaModel_Id, t.PacientModel_Id })
                .ForeignKey("dbo.DiagnozaModels", t => t.DiagnozaModel_Id, cascadeDelete: true)
                .ForeignKey("dbo.PacientModels", t => t.PacientModel_Id, cascadeDelete: true)
                .Index(t => t.DiagnozaModel_Id)
                .Index(t => t.PacientModel_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PriznakModels", "PacientModelId", "dbo.PacientModels");
            DropForeignKey("dbo.GenetickeVysetrenieModels", "PacientModelId", "dbo.PacientModels");
            DropForeignKey("dbo.DiagnozaModelPacientModels", "PacientModel_Id", "dbo.PacientModels");
            DropForeignKey("dbo.DiagnozaModelPacientModels", "DiagnozaModel_Id", "dbo.DiagnozaModels");
            DropIndex("dbo.DiagnozaModelPacientModels", new[] { "PacientModel_Id" });
            DropIndex("dbo.DiagnozaModelPacientModels", new[] { "DiagnozaModel_Id" });
            DropIndex("dbo.PriznakModels", new[] { "PacientModelId" });
            DropIndex("dbo.GenetickeVysetrenieModels", new[] { "PacientModelId" });
            DropTable("dbo.DiagnozaModelPacientModels");
            DropTable("dbo.PriznakModels");
            DropTable("dbo.GenetickeVysetrenieModels");
            DropTable("dbo.DiagnozaModels");
            DropTable("dbo.PacientModels");
        }
    }
}
