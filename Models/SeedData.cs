using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbbyWakeAss5.Models
{
    public class SeedData
    {
        //using the context to equal our BookDbContext
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            BookDbContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BookDbContext>();

            if(context.Database.GetPendingMigrations().Any())
            {
                //allowing it to Migrate and update
                context.Database.Migrate();
            }
            if(!context.Books.Any())
            {
                context.Books.AddRange(
                    //can delete because it's pulling from the database, but this is where we added all of the information for the books and publishers and what not 
                
                new Books
                {
                   
                    Title = "Les Miserables",
                    AuthorFirst = "Victor",
                    AuthorLast = "Hugo",
                    Publisher = "Signet",
                    ISBN = 978-0451419439,
                    Classification = "Fiction",
                    Category = "Classic",
                    Price = 9.95f
                }, 

                new Books
                {
                   
                    Title = "Team of Rivals",
                    AuthorFirst = "Doris",
                    AuthorMiddle = "Kearns",
                    AuthorLast = "Goodwin",
                    Publisher = "Simon & Schuster",
                    ISBN = 978-0743270755,
                    Classification = "Non-Fiction",
                    Category = "Biography",
                    Price = 14.58f

                },

                 new Books
                 {
                   
                     Title = "The Snowball",
                     AuthorFirst = "Alice",
                     AuthorLast = "Schroeder",
                     Publisher = "Bantam",
                     ISBN = 978-0553384611,
                     Classification = "Non-Fiction",
                     Category = "Biography",
                     Price = 21.54f

                 },

                 new Books
                 {
                     Title = "American Ulysses",
                     AuthorFirst = "Ronald",
                     AuthorMiddle = "C",
                     AuthorLast = "White",
                     Publisher = "Random House",
                     ISBN = 978-0812981254,
                     Classification = "Non-Fiction",
                     Category = "Biography",
                     Price = 11.61f
                 },

                  new Books
                  {
                      Title = "Unbroken",
                      AuthorFirst = "Laura",
                      AuthorLast = "Hillenbrand",
                      Publisher = "Random House",
                      ISBN = 978 - 0812974492,
                      Classification = "Non-Fiction",
                      Category = "Historical",
                      Price = 13.33f
                  },

                   new Books
                   {
                       Title = "The Great Train Robbery",
                       AuthorFirst = "Michael",
                       AuthorLast = "Crichton",
                       Publisher = "Vintage",
                       ISBN = 978 - 0804171281,
                       Classification = "Fiction",
                       Category = "Historical Fiction",
                       Price = 15.95f
                   },
                    new Books
                    {
                        Title = "Deep Work",
                        AuthorFirst = "Cal",
                        AuthorLast = "Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = 978 - 1455586691,
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 14.99f

                    },
                      new Books
                      {
                          Title = "It's Your Ship",
                          AuthorFirst = "Michael",
                          AuthorLast = "Abrashoff",
                          Publisher = "Grand Central Publishing",
                          ISBN = 978 - 1455523023,
                          Classification = "Non-Fiction",
                          Category = "Self-Help",
                          Price = 21.66f

                      },
                      new Books
                      {
                          Title = "The Virgin Way",
                          AuthorFirst = "Richard",
                          AuthorLast = "Branson",
                          Publisher = "Portfolio ",
                          ISBN = 978 - 1591847984,
                          Classification = "Non-Fiction",
                          Category = "Business",
                          Price = 29.16f

                      },
                      new Books
                      {
                            Title = "Sycamore Row",
                            AuthorFirst = "John",
                            AuthorLast = "Grisham",
                            Publisher = "Bantam",
                            ISBN = 978 - 0553393613,
                            Classification = "Fiction",
                            Category = "Thrillers",
                            Price = 15.03f

                      }




                );
                context.SaveChanges();
            }
        }
    }
}
