namespace BELibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTypeToMedicineTable1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Medicine", "Type", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Medicine", "Type");
        }
    }
}
