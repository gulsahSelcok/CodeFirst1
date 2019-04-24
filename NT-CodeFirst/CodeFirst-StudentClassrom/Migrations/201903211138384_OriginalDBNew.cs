namespace CodeFirst_StudentClassrom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OriginalDBNew : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "classroom_ClassroomID", "dbo.Classrooms");
            DropIndex("dbo.Students", new[] { "classroom_ClassroomID" });
            RenameColumn(table: "dbo.Students", name: "classroom_ClassroomID", newName: "ClassroomID");
            AlterColumn("dbo.Students", "ClassroomID", c => c.Int(nullable: false));
            CreateIndex("dbo.Students", "ClassroomID");
            AddForeignKey("dbo.Students", "ClassroomID", "dbo.Classrooms", "ClassroomID", cascadeDelete: true);
            DropColumn("dbo.Students", "ClassID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "ClassID", c => c.Int(nullable: false));
            DropForeignKey("dbo.Students", "ClassroomID", "dbo.Classrooms");
            DropIndex("dbo.Students", new[] { "ClassroomID" });
            AlterColumn("dbo.Students", "ClassroomID", c => c.Int());
            RenameColumn(table: "dbo.Students", name: "ClassroomID", newName: "classroom_ClassroomID");
            CreateIndex("dbo.Students", "classroom_ClassroomID");
            AddForeignKey("dbo.Students", "classroom_ClassroomID", "dbo.Classrooms", "ClassroomID");
        }
    }
}
