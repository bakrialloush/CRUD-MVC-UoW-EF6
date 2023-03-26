namespace CRUD_UoW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Auths",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 20),
                        Time = c.DateTime(nullable: false),
                        Auth_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Auths", t => t.Auth_Id)
                .Index(t => t.Title, unique: true)
                .Index(t => t.Auth_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "Auth_Id", "dbo.Auths");
            DropIndex("dbo.Posts", new[] { "Auth_Id" });
            DropIndex("dbo.Posts", new[] { "Title" });
            DropIndex("dbo.Auths", new[] { "Name" });
            DropTable("dbo.Posts");
            DropTable("dbo.Auths");
        }
    }
}
