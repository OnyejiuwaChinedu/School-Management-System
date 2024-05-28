namespace SchoolManagementSystem.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Secondmigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Schedules", "Course_Id_Id", c => c.Int());
            AddColumn("dbo.Schedules", "Staff_Id_Id", c => c.Int());
            AddColumn("dbo.Schedules", "Student_Id_Id", c => c.Int());
            AddColumn("dbo.Subjects", "Course_Id_Id", c => c.Int());
            AddColumn("dbo.Transactions", "Student_Id_Id", c => c.Int());
            CreateIndex("dbo.Schedules", "Course_Id_Id");
            CreateIndex("dbo.Schedules", "Staff_Id_Id");
            CreateIndex("dbo.Schedules", "Student_Id_Id");
            CreateIndex("dbo.Subjects", "Course_Id_Id");
            CreateIndex("dbo.Transactions", "Student_Id_Id");
            AddForeignKey("dbo.Schedules", "Course_Id_Id", "dbo.Courses", "Id");
            AddForeignKey("dbo.Schedules", "Staff_Id_Id", "dbo.Staffs", "Id");
            AddForeignKey("dbo.Schedules", "Student_Id_Id", "dbo.Students", "Id");
            AddForeignKey("dbo.Subjects", "Course_Id_Id", "dbo.Courses", "Id");
            AddForeignKey("dbo.Transactions", "Student_Id_Id", "dbo.Students", "Id");
            DropColumn("dbo.Schedules", "Student_Id");
            DropColumn("dbo.Schedules", "Course_Id");
            DropColumn("dbo.Schedules", "Staff_Id");
            DropColumn("dbo.Subjects", "Course_Id");
            DropColumn("dbo.Transactions", "Student_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Transactions", "Student_Id", c => c.String());
            AddColumn("dbo.Subjects", "Course_Id", c => c.String());
            AddColumn("dbo.Schedules", "Staff_Id", c => c.String());
            AddColumn("dbo.Schedules", "Course_Id", c => c.String());
            AddColumn("dbo.Schedules", "Student_Id", c => c.String());
            DropForeignKey("dbo.Transactions", "Student_Id_Id", "dbo.Students");
            DropForeignKey("dbo.Subjects", "Course_Id_Id", "dbo.Courses");
            DropForeignKey("dbo.Schedules", "Student_Id_Id", "dbo.Students");
            DropForeignKey("dbo.Schedules", "Staff_Id_Id", "dbo.Staffs");
            DropForeignKey("dbo.Schedules", "Course_Id_Id", "dbo.Courses");
            DropIndex("dbo.Transactions", new[] { "Student_Id_Id" });
            DropIndex("dbo.Subjects", new[] { "Course_Id_Id" });
            DropIndex("dbo.Schedules", new[] { "Student_Id_Id" });
            DropIndex("dbo.Schedules", new[] { "Staff_Id_Id" });
            DropIndex("dbo.Schedules", new[] { "Course_Id_Id" });
            DropColumn("dbo.Transactions", "Student_Id_Id");
            DropColumn("dbo.Subjects", "Course_Id_Id");
            DropColumn("dbo.Schedules", "Student_Id_Id");
            DropColumn("dbo.Schedules", "Staff_Id_Id");
            DropColumn("dbo.Schedules", "Course_Id_Id");
        }
    }
}
