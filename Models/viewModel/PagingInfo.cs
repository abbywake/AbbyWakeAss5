using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbbyWakeAss5.Models.viewModel
{
    //paging info page - making it so it will get the total pages through maths
    public class PagingInfo
    {
        public int TotalNumItems { get; set; }

        public int ItemsPerPage { get; set; }

        public int CurrentPage { get; set; }

        public int TotalPages => (int)(Math.Ceiling((decimal) TotalNumItems / ItemsPerPage));
    }
}
