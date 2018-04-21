namespace App_01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProfessorTable : DbMigration
    {
        public override void Up()
        {
            
            CreateTable(
               "dbo.Professors",
               c => new
               {
                   ID = c.Int(nullable: false, identity:true),
                   Name = c.String(),
                   University = c.String(),
                   Department = c.String(),
                   UserId = c.String(nullable: false, maxLength: 128),
               })
               .PrimaryKey(t => t.ID)
               .ForeignKey("AspNetUsers", t => t.UserId, cascadeDelete: true)
               .Index(t => t.UserId);
        
    }
        
        public override void Down()
        {
            DropForeignKey("dbo.Professors", "UserId", "AspNetUsers");
            DropIndex("dbo.Professors", "UserId");
            DropTable("dbo.Enrollment");
               
    }
    }
}
