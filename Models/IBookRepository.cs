using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbbyWakeAss5.Models
{
    public interface IBookRepository

        //Honestly, not sure what this does, but it's here
    {
        IQueryable<Books> Books { get; }


    }
}
