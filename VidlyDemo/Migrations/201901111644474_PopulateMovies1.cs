namespace VidlyDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies1 : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO Movies(Name, Genre, ReleaseDate, AddedDate, StockNumber) " +
               "VALUES ('The Terminator', 'Action, Sci-Fi', '10-26-1984', '12-22-2016', 5);");

            Sql("INSERT INTO Movies(Name, Genre, ReleaseDate, AddedDate, StockNumber) " +
              "VALUES ('Aliens', 'Action, Adventure, Sci-Fi', '07-18-1986', '06-13-2015', 10);");

            Sql("INSERT INTO Movies(Name, Genre, ReleaseDate, AddedDate, StockNumber) " +
              "VALUES ('Predator ', 'Action, Adventure, Sci-Fi', '05-12-1987', '11-15-2014', 15);");

        }

        public override void Down()
        {
        }
    }
}
