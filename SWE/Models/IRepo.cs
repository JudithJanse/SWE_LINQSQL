﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWE.Models
{
    public interface IRepo
    {
        public IQueryable<Book> Books { get; }

        public IQueryable<Author> Authors {get;}

        void Add<Entitytype>(Entitytype entity);
        void SaveChanges();


    }
}
