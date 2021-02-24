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
                


                    //delete database then re-add through dotnet ef migrations add databaseName
                new Books
                {
                   
                    Title = "Les Miserables",
                    AuthorFirst = "Victor",
                    AuthorLast = "Hugo",
                    Publisher = "Signet",
                    ISBN = 978-0451419439,
                    Classification = "Fiction",
                    Category = "Classic",
                    Price = 9.95f, 
                    PageNum = 1488
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
                    Price = 14.58f,
                    PageNum = 944

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
                     Price = 21.54f,
                     PageNum = 832

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
                     Price = 11.61f,
                     PageNum = 864
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
                      Price = 13.33f,
                      PageNum = 528
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
                       Price = 15.95f,
                       PageNum = 288
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
                        Price = 14.99f,
                        PageNum = 304

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
                          Price = 21.66f,
                          PageNum = 240

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
                          Price = 29.16f,
                          PageNum = 400

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
                            Price = 15.03f,
                            PageNum = 642

                      },
                      //my own added books 
                       new Books
                       {
                           Title = "The Help",
                           AuthorFirst = "Kathryne",
                           AuthorLast = "Socket",
                           Publisher = "Penguin Books",
                           ISBN = 978 - 0143144182,
                           Classification = "Drama",
                           Category = "Romance",
                           Price = 15.39f,
                           PageNum = 466

                       },
                       new Books
                       {
                           Title = "Thinner Leaner Stronger",
                           AuthorFirst = "Michael",
                           AuthorLast = "Matthews",
                           Publisher = "Ingram",
                           ISBN = 978 - 1479291281,
                           Classification = "Diet Book",
                           Category = "Self-Help",
                           Price = 16.99f,
                           PageNum = 643

                       },
                        new Books
                        {
                            Title = "The Girl With Seven Names",
                            AuthorFirst = "Hyeon-Seo",
                            AuthorLast = "Lee",
                            Publisher = "HarperCollins UK",
                            ISBN = 978 - 0008338336,
                            Classification = "Autobiography",
                            Category = "Biography",
                            Price = 16.99f,
                            PageNum = 342

                        }




                );
                context.SaveChanges();
            }
        }
    }
}
