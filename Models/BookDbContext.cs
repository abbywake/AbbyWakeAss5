using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbbyWakeAss5.Models
{
    public class BookDbContext : DbContext
    {
        //giving inheritance
        public BookDbContext (DbContextOptions<BookDbContext> options): base (options)
        {

        }
        //getting and settings the Books Data 
        public DbSet<Books> Books { get; set; }
    }
}
