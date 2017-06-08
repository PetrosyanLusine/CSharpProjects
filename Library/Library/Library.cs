﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Library
{
    [DataContract]
    class Library
    {
        public List<Book> Books { get; set; }
        public List<User> Users { get; set; }
        public decimal Money { get; set; }
    }

}
