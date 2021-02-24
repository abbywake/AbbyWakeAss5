using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbbyWakeAss5.Models.viewModel
{//iEnumerable so we can iterate through the Books
    public class ProjectListViewModel
    {
        public IEnumerable<Books> Books { get; set; }

        public PagingInfo PagingInfo { get; set; }


    }
}
