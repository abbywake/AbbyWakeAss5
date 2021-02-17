using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbbyWakeAss5.Models
{
    public class EFBookRepository: IBookRepository
    
    {
        
        private BookDbContext _context;

        //basically just setting the context equal to the BookDbContext to use it in IQueryable
        public EFBookRepository (BookDbContext context)
        {
            _context = context;
        }

        public IQueryable<Books> Books => _context.Books;
    }
}
