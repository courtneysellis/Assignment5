using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            BookstoreDbContext context =
                application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BookstoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Books.Any())
            {
                context.Books.AddRange(

                    new Book
                    {
                        ISBN = "978-0451419439",
                        Title = "Les Miserables",
                        AuthorFirstName = "Victor",
                        AuthorLastName = "Hugo",
                        Classification = "Fiction",
                        Category = "Classic",
                        Publisher = "Signet",
                        Price = 9.95
                    },

                    new Book
                    {
                        ISBN = "978-0743270755",
                        Title = "Team of Rivals",
                        AuthorFirstName = "Doris",
                        AuthorLastName = "Kearns Goodwin",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Publisher = "Simon & Schuster",
                        Price = 14.58
                    },

                    new Book
                    {
                        ISBN = "978-0553384611",
                        Title = "The Snowball",
                        AuthorFirstName = "Alice",
                        AuthorLastName = "Schroeder",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Publisher = "Bantam",
                        Price = 21.54
                    },

                    new Book
                    {
                        ISBN = "978-0812981254",
                        Title = "American Ulysses",
                        AuthorFirstName = "Ronald C.",
                        AuthorLastName = "White",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Publisher = "Random House",
                        Price = 11.61
                    },

                    new Book
                    {
                        ISBN = "978-0812974492",
                        Title = "Unbroken",
                        AuthorFirstName = "Laura",
                        AuthorLastName = "Hillenbrand",
                        Classification = "Non-Fiction",
                        Category = "Historical",
                        Publisher = "Random House",
                        Price = 13.33
                    },

                    new Book
                    {
                        ISBN = "978-0804171281",
                        Title = "The Great Train Robbery",
                        AuthorFirstName = "Micheal",
                        AuthorLastName = "Crichton",
                        Classification = "Fiction",
                        Category = "Historical Fiction",
                        Publisher = "Vintage",
                        Price = 15.95
                    },

                    new Book
                    {
                        ISBN = "978-1455586691",
                        Title = "Deep Work",
                        AuthorFirstName = "Cal",
                        AuthorLastName = "Newport",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Publisher = "Grand Central Publishing",
                        Price = 14.99
                    },

                    new Book
                    {
                        ISBN = "978-1455523023",
                        Title = "It's Your Ship",
                        AuthorFirstName = "Michael",
                        AuthorLastName = "Abrashoff",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Publisher = "Grand Central Publishing",
                        Price = 21.66
                    },

                    new Book
                    {
                        ISBN = "978-1591847984",
                        Title = "The Virgin Way",
                        AuthorFirstName = "Richard",
                        AuthorLastName = "Branson",
                        Classification = "Non-Fiction",
                        Category = "Business",
                        Publisher = "Portfolio",
                        Price = 29.16
                    },

                    new Book
                    {
                        ISBN = "978-0553393613",
                        Title = "Sycamore  Row",
                        AuthorFirstName = "John",
                        AuthorLastName = "Grisham",
                        Classification = "Fiction",
                        Category = "Thrillers",
                        Publisher = "Bantam",
                        Price = 15.03
                    }

                );

                context.SaveChanges();
            }
        }
    }
}
