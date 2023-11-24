namespace K2E.DataAcess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 80),
                        Descripcion = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Chapters",
                c => new
                    {
                        CapituloId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        CantidadTitulo = c.Int(nullable: false),
                        Tiempo = c.DateTime(nullable: false),
                        CursoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CapituloId);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        ComentarioId = c.Int(nullable: false, identity: true),
                        CursoId = c.Int(nullable: false),
                        Email = c.String(nullable: false, maxLength: 50),
                        Mensaje = c.String(nullable: false, maxLength: 50),
                        Fecha = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ComentarioId);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CursoId = c.Int(nullable: false, identity: true),
                        Titulo = c.String(nullable: false, maxLength: 25),
                        CategoriaId = c.Int(nullable: false),
                        Subtitulo = c.String(nullable: false, maxLength: 50),
                        FechaPublicacion = c.DateTime(nullable: false),
                        Descripcion = c.String(nullable: false),
                        InstructorId = c.Int(nullable: false),
                        Portada = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CursoId);
            
            CreateTable(
                "dbo.Instructors",
                c => new
                    {
                        InstructorId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        TituloEspecialidad = c.String(nullable: false, maxLength: 100),
                        SobreMi = c.String(nullable: false),
                        UrlSite = c.String(),
                        UrlX = c.String(),
                        UrlLink = c.String(),
                        UrlYt = c.String(),
                        UrlFb = c.String(),
                    })
                .PrimaryKey(t => t.InstructorId);
            
            CreateTable(
                "dbo.Rols",
                c => new
                    {
                        RolId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.RolId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false, maxLength: 60),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        Nacionalidad = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.StudentId);
            
            CreateTable(
                "dbo.Titles",
                c => new
                    {
                        TituloId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Tiempo = c.DateTime(nullable: false),
                        CapituloId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TituloId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Email = c.String(nullable: false, maxLength: 40),
                        Clave = c.String(nullable: false, maxLength: 30),
                        RolId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Email);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Titles");
            DropTable("dbo.Students");
            DropTable("dbo.Rols");
            DropTable("dbo.Instructors");
            DropTable("dbo.Courses");
            DropTable("dbo.Comments");
            DropTable("dbo.Chapters");
            DropTable("dbo.Categories");
        }
    }
}
