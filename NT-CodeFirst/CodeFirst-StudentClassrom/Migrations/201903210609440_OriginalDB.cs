namespace CodeFirst_StudentClassrom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OriginalDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classrooms",
                c => new
                    {
                        ClassroomID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ClassroomID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.Long(nullable: false, identity: true),
                        FullName = c.String(),
                        ClassID = c.Int(nullable: false),
                        classroom_ClassroomID = c.Int(),
                    })
                .PrimaryKey(t => t.StudentID)
                .ForeignKey("dbo.Classrooms", t => t.classroom_ClassroomID)
                .Index(t => t.classroom_ClassroomID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "classroom_ClassroomID", "dbo.Classrooms");
            DropIndex("dbo.Students", new[] { "classroom_ClassroomID" });
            DropTable("dbo.Students");
            DropTable("dbo.Classrooms");
        }
    }
}
