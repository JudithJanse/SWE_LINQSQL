﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWE.Models
{
    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Author Author { get; set; }

    }
}
