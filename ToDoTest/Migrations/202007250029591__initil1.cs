namespace ToDoTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _initil1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ToDoModels", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.ToDoModels", new[] { "User_Id" });
            RenameColumn(table: "dbo.ToDoModels", name: "User_Id", newName: "UserAcct_Id");
            AlterColumn("dbo.ToDoModels", "UserAcct_Id", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.ToDoModels", "UserAcct_Id");
            AddForeignKey("dbo.ToDoModels", "UserAcct_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ToDoModels", "UserAcct_Id", "dbo.AspNetUsers");
            DropIndex("dbo.ToDoModels", new[] { "UserAcct_Id" });
            AlterColumn("dbo.ToDoModels", "UserAcct_Id", c => c.String(maxLength: 128));
            RenameColumn(table: "dbo.ToDoModels", name: "UserAcct_Id", newName: "User_Id");
            CreateIndex("dbo.ToDoModels", "User_Id");
            AddForeignKey("dbo.ToDoModels", "User_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
