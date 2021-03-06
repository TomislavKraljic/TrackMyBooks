﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrackMyBooks.Model
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Author { get; set; }
        public int ISBN { get; set; }
        public string Condition { get; set; }
        public string DateCheckedOut { get; set; }
        public string DateReturned { get; set; }

    }
}
