namespace presentacion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicio : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Advices", "Profile_Id", "dbo.Profiles");
            DropForeignKey("dbo.Profiles", "Contact_Id", "dbo.Contacts");
            DropForeignKey("dbo.Profiles", "Expert_Id", "dbo.Experts");
            DropForeignKey("dbo.Updates", "Profile_Id", "dbo.Profiles");
            DropIndex("dbo.Advices", new[] { "Profile_Id" });
            DropIndex("dbo.Profiles", new[] { "Contact_Id" });
            DropIndex("dbo.Profiles", new[] { "Expert_Id" });
            DropIndex("dbo.Updates", new[] { "Profile_Id" });
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                        Age = c.Int(nullable: false),
                        City = c.String(),
                        Response_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Responses", t => t.Response_Id)
                .Index(t => t.Response_Id);
            
            CreateTable(
                "dbo.Responses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TestQuestion_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TestQuestions", t => t.TestQuestion_Id)
                .Index(t => t.TestQuestion_Id);
            
            CreateTable(
                "dbo.TestQuestions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Question_Id = c.Int(),
                        Test_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Questions", t => t.Question_Id)
                .ForeignKey("dbo.Tests", t => t.Test_Id)
                .Index(t => t.Question_Id)
                .Index(t => t.Test_Id);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Expert_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Experts", t => t.Expert_Id)
                .Index(t => t.Expert_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Password = c.String(),
                        Client_Id = c.Int(),
                        Expert_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.Client_Id)
                .ForeignKey("dbo.Experts", t => t.Expert_Id)
                .Index(t => t.Client_Id)
                .Index(t => t.Expert_Id);
            
            AddColumn("dbo.Experts", "Age", c => c.Int(nullable: false));
            AddColumn("dbo.Experts", "City", c => c.String());
            DropColumn("dbo.Experts", "UserName");
            DropColumn("dbo.Experts", "Email");
            DropColumn("dbo.Experts", "Password");
            DropTable("dbo.Advices");
            DropTable("dbo.Profiles");
            DropTable("dbo.Contacts");
            DropTable("dbo.Updates");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Updates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Reciclyng = c.Double(nullable: false),
                        PollutionReduction = c.Double(nullable: false),
                        Ecology = c.Double(nullable: false),
                        ActiveParticipation = c.Double(nullable: false),
                        Profile_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Phone = c.Int(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Profiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                        Age = c.Int(nullable: false),
                        UserName = c.String(),
                        Password = c.String(),
                        City = c.String(),
                        Contact_Id = c.Int(),
                        Expert_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Advices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                        Author = c.String(),
                        Profile_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Experts", "Password", c => c.String());
            AddColumn("dbo.Experts", "Email", c => c.String());
            AddColumn("dbo.Experts", "UserName", c => c.String());
            DropForeignKey("dbo.TestQuestions", "Test_Id", "dbo.Tests");
            DropForeignKey("dbo.Users", "Expert_Id", "dbo.Experts");
            DropForeignKey("dbo.Users", "Client_Id", "dbo.Clients");
            DropForeignKey("dbo.Tests", "Expert_Id", "dbo.Experts");
            DropForeignKey("dbo.Responses", "TestQuestion_Id", "dbo.TestQuestions");
            DropForeignKey("dbo.TestQuestions", "Question_Id", "dbo.Questions");
            DropForeignKey("dbo.Clients", "Response_Id", "dbo.Responses");
            DropIndex("dbo.Users", new[] { "Expert_Id" });
            DropIndex("dbo.Users", new[] { "Client_Id" });
            DropIndex("dbo.Tests", new[] { "Expert_Id" });
            DropIndex("dbo.TestQuestions", new[] { "Test_Id" });
            DropIndex("dbo.TestQuestions", new[] { "Question_Id" });
            DropIndex("dbo.Responses", new[] { "TestQuestion_Id" });
            DropIndex("dbo.Clients", new[] { "Response_Id" });
            DropColumn("dbo.Experts", "City");
            DropColumn("dbo.Experts", "Age");
            DropTable("dbo.Users");
            DropTable("dbo.Tests");
            DropTable("dbo.Questions");
            DropTable("dbo.TestQuestions");
            DropTable("dbo.Responses");
            DropTable("dbo.Clients");
            CreateIndex("dbo.Updates", "Profile_Id");
            CreateIndex("dbo.Profiles", "Expert_Id");
            CreateIndex("dbo.Profiles", "Contact_Id");
            CreateIndex("dbo.Advices", "Profile_Id");
            AddForeignKey("dbo.Updates", "Profile_Id", "dbo.Profiles", "Id");
            AddForeignKey("dbo.Profiles", "Expert_Id", "dbo.Experts", "Id");
            AddForeignKey("dbo.Profiles", "Contact_Id", "dbo.Contacts", "Id");
            AddForeignKey("dbo.Advices", "Profile_Id", "dbo.Profiles", "Id");
        }
    }
}
