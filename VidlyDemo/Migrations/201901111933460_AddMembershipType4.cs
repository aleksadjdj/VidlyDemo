namespace VidlyDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipType4 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.MembershipTypes", "MembershipTypeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MembershipTypes", "MembershipTypeId", c => c.Int(nullable: false));
        }
    }
}
