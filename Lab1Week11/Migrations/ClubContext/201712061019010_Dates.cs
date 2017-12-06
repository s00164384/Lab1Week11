namespace Lab1Week11.Migrations.ClubContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Dates : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ClubEvent", "StartDateTime", c => c.DateTime());
            AlterColumn("dbo.ClubEvent", "EndDateTime", c => c.DateTime());
            AlterColumn("dbo.Club", "CreationDate", c => c.DateTime(storeType: "date"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Club", "CreationDate", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.ClubEvent", "EndDateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ClubEvent", "StartDateTime", c => c.DateTime(nullable: false));
        }
    }
}
