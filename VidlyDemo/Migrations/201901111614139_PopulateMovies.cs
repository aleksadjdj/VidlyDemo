namespace VidlyDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies(Name, Genre, ReleaseDate, AddedDate, StockNumber) " +
                "VALUES ('Hangover', 'Comedy', '12-05-2009', '01-11-2018', 6);");
        }
        
        public override void Down()
        {
        }
    }
}
