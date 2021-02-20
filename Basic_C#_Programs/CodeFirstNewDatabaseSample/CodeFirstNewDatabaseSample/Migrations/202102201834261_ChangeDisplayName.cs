namespace CodeFirstNewDatabaseSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDisplayName : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Users", name: "DisplayName", newName: "displey_name");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Users", name: "displey_name", newName: "DisplayName");
        }
    }
}
