namespace ToDoTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _initil2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ToDoModels", "UserAcct_Id", "dbo.AspNetUsers");
            DropIndex("dbo.ToDoModels", new[] { "UserAcct_Id" });
            AddColumn("dbo.ToDoModels", "UserId", c => c.String(nullable: false));
            AlterColumn("dbo.ToDoModels", "UserAcct_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.ToDoModels", "UserAcct_Id");
            AddForeignKey("dbo.ToDoModels", "UserAcct_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ToDoModels", "UserAcct_Id", "dbo.AspNetUsers");
            DropIndex("dbo.ToDoModels", new[] { "UserAcct_Id" });
            AlterColumn("dbo.ToDoModels", "UserAcct_Id", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.ToDoModels", "UserId");
            CreateIndex("dbo.ToDoModels", "UserAcct_Id");
            AddForeignKey("dbo.ToDoModels", "UserAcct_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
    }
}
