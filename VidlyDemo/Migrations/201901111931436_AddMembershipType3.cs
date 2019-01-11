namespace VidlyDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipType3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "MembershipTypeId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "MembershipTypeId");
        }
    }
}
