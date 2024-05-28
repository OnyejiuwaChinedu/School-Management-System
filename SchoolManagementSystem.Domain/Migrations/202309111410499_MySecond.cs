namespace SchoolManagementSystem.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MySecond : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Schedules", "Course_Id_Id", "dbo.Courses");
            DropForeignKey("dbo.Schedules", "Staff_Id_Id", "dbo.Staffs");
            DropForeignKey("dbo.Schedules", "Student_Id_Id", "dbo.Students");
            DropIndex("dbo.Schedules", new[] { "Course_Id_Id" });
            DropIndex("dbo.Schedules", new[] { "Staff_Id_Id" });
            DropIndex("dbo.Schedules", new[] { "Student_Id_Id" });
            AddColumn("dbo.Schedules", "Student_Id", c => c.Int(nullable: false));
            AddColumn("dbo.Schedules", "Course_Id", c => c.Int(nullable: false));
            AddColumn("dbo.Schedules", "Staff_Id", c => c.Int(nullable: false));
            DropColumn("dbo.Schedules", "Course_Id_Id");
            DropColumn("dbo.Schedules", "Staff_Id_Id");
            DropColumn("dbo.Schedules", "Student_Id_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Schedules", "Student_Id_Id", c => c.Int());
            AddColumn("dbo.Schedules", "Staff_Id_Id", c => c.Int());
            AddColumn("dbo.Schedules", "Course_Id_Id", c => c.Int());
            DropColumn("dbo.Schedules", "Staff_Id");
            DropColumn("dbo.Schedules", "Course_Id");
            DropColumn("dbo.Schedules", "Student_Id");
            CreateIndex("dbo.Schedules", "Student_Id_Id");
            CreateIndex("dbo.Schedules", "Staff_Id_Id");
            CreateIndex("dbo.Schedules", "Course_Id_Id");
            AddForeignKey("dbo.Schedules", "Student_Id_Id", "dbo.Students", "Id");
            AddForeignKey("dbo.Schedules", "Staff_Id_Id", "dbo.Staffs", "Id");
            AddForeignKey("dbo.Schedules", "Course_Id_Id", "dbo.Courses", "Id");
        }
    }
}
