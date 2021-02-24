using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookstore.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            BookDbContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BookDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Books.Any())
            {
                //Seed the database with this prepopulation data
                context.Books.AddRange(
                    new Book
                    {
                        Title = "Les Miserables",
                        AuthorFirstName = "Victor",
                        AuthorSurname = "Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        Price = 9.95m,
                        PageCount = 1488
                    },
                    new Book
                    {
                        Title = "Team of Rivals",
                        AuthorFirstName = "Doris",
                        AuthorMiddleName = "Kearns",
                        AuthorSurname = "Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 14.58m,
                        PageCount = 944
                    },
                    new Book
                    {
                        Title = "The Snowball",
                        AuthorFirstName = "Alice",
                        AuthorSurname = "Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 21.54m,
                        PageCount = 832
                    },
                    new Book
                    {
                        Title = "American Ulysses",
                        AuthorFirstName = "Ronald",
                        AuthorMiddleName = "C.",
                        AuthorSurname = "White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 11.61m,
                        PageCount = 864
                    },
                    new Book
                    {
                        Title = "Unbroken",
                        AuthorFirstName = "Laura",
                        AuthorSurname = "Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        Classification = "Non-Fiction",
                        Category = "Historical",
                        Price = 13.33m,
                        PageCount = 528
                    },
                    new Book
                    {
                        Title = "The Great Train Robbery",
                        AuthorFirstName = "Michael",
                        AuthorSurname = "Chrichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Classification = "Fiction",
                        Category = "Historical Fiction",
                        Price = 15.95m,
                        PageCount = 288
                    },
                    new Book
                    {
                        Title = "Deep Work",
                        AuthorFirstName = "Cal",
                        AuthorSurname = "Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 14.99m,
                        PageCount = 304
                    },
                    new Book
                    {
                        Title = "It\'s Your Ship",
                        AuthorFirstName = "Michael",
                        AuthorSurname = "Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 21.66m,
                        PageCount = 240
                    },
                    new Book
                    {
                        Title = "The Virgin Way",
                        AuthorFirstName = "Richard",
                        AuthorSurname = "Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Classification = "Non-Fiction",
                        Category = "Business",
                        Price = 29.16m,
                        PageCount = 400
                    },
                    new Book
                    {
                        Title = "Sycamore Row",
                        AuthorFirstName = "John",
                        AuthorSurname = "Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Classification = "Fiction",
                        Category = "Thrillers",
                        Price = 15.03m,
                        PageCount = 642
                    },
                    new Book
                    {
                        Title = "Quiet: The Power of Introverts in a World That Can't Stop Talking",
                        AuthorFirstName = "Susan",
                        AuthorSurname = "Cain",
                        Publisher = "Crown",
                        ISBN = "978-0141029191",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 7.89m,
                        PageCount = 333
                    },
                    new Book
                    {
                        Title = "The Lord of the Rings, The Fellowship of the Ring",
                        AuthorFirstName = "J.",
                        AuthorMiddleName = "R.R.",
                        AuthorSurname = "Tolkien",
                        Publisher = "Allen & Unwin",
                        ISBN = "978-0007269709",
                        Classification = "Fiction",
                        Category = "Fantasy",
                        Price = 8.49m,
                        PageCount = 423
                    },
                    new Book
                    {
                        Title = "Mooses Come Walking",
                        AuthorFirstName = "Arlo",
                        AuthorSurname = "Guthrie",
                        Publisher = "Chronicle Books",
                        ISBN = "978-0811810517",
                        Classification = "Fiction",
                        Category = "Children's Literature",
                        Price = 9.36m,
                        PageCount = 32
                    }
                );

                context.SaveChanges();
            }    
        }
    }
}
