namespace BookService.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using BookService.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<BookService.Models.BookServiceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BookService.Models.BookServiceContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Authors.AddOrUpdate( x => x.Id,
              new Author() { Id = 1, Name = "Emily Esfahany" },
              new Author() { Id = 2, Name = "Bill Burnett" },
              new Author() { Id =3, Name = "Wa'fa Tarnovska" }
            );
            context.Books.AddOrUpdate(x => x.Id,
                new Book()
                {
                    Id = 1,
                    Title = "The Power of Meaning",
                    Year = 2016,
                    AuthorId = 1,
                    Price = 15.95M,
                    Genre = "Non-fiction"
                },
                new Book()
                {
                    Id = 2,
                    Title = "Designing Your Life",
                    Year = 2016,
                    AuthorId = 2,
                    Price = 13.99M,
                    Genre = "Non-fiction"
                },
                new Book()
                {
                    Id = 3,
                    Title = "The Arabian Nights",
                    Year = 2004,
                    AuthorId = 3,
                    Price = 20.99M,
                    Genre = "Folktale"
                }
            );
        }
    }
}
