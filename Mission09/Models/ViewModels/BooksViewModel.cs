using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mission09.Models.ViewModels;

namespace Mission09.Models.ViewModels
{
    public class BooksViewModel
    {
        public IQueryable<Books> Books { get; set; }
        public PageInfo PageInfo { get; set; }
    }
}