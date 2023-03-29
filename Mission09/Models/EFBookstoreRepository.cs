
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mission09.Models;

namespace Mission09.Models
{
    public class EFBookstoreRepository : IBookstoreRepository
    {
        private BookstoreContext context { get; set; }

        public EFBookstoreRepository(BookstoreContext bc)
        {
            context = bc;
        }

        public IQueryable<Books> Books => context.Books;
    }
}