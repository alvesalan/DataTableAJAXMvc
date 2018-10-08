namespace Tabela.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicio2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Usuarios", "Nome", c => c.String(nullable: false));
            AlterColumn("dbo.Usuarios", "Cor", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Usuarios", "Cor", c => c.String());
            AlterColumn("dbo.Usuarios", "Nome", c => c.String());
        }
    }
}
