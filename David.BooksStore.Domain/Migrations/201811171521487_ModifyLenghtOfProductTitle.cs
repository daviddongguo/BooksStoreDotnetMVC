namespace David.BooksStore.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyLenghtOfProductTitle : DbMigration
    {
        public override void Up()
        {
            AlterColumn("booksStore.Products", "Title", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("booksStore.Products", "Author", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("booksStore.Products", "Author", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("booksStore.Products", "Title", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
