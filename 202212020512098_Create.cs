namespace FBLmannagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AddResults",
                c => new
                    {
                        MatchID = c.Int(nullable: false),
                        Teamname1 = c.String(),
                        Teamname2 = c.String(),
                        StatusTeam = c.String(),
                        WinningTeam = c.String(),
                    })
                .PrimaryKey(t => t.MatchID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AddResults");
        }
    }
}
