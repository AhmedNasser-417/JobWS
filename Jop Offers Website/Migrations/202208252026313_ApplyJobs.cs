namespace Jop_Offers_Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyJobs : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ApplayForJobs", "JobId", "dbo.Jobs");
            DropForeignKey("dbo.ApplayForJobs", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.ApplayForJobs", new[] { "JobId" });
            DropIndex("dbo.ApplayForJobs", new[] { "UserId" });
            DropTable("dbo.ApplayForJobs");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ApplayForJobs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Message = c.String(),
                        ApplyDate = c.DateTime(nullable: false),
                        JobId = c.Int(nullable: false),
                        UserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.ApplayForJobs", "UserId");
            CreateIndex("dbo.ApplayForJobs", "JobId");
            AddForeignKey("dbo.ApplayForJobs", "UserId", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.ApplayForJobs", "JobId", "dbo.Jobs", "Id", cascadeDelete: true);
        }
    }
}
