﻿using System;
using System.Collections.Generic;

#nullable disable

namespace SqlOperationsEntityFrameworkCore.Models
{
    public partial class Categories
    {
        public Categories()
        {
            Products = new HashSet<Products>();
        }

        /// <summary>
        /// Primary key
        /// </summary>
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }

        public virtual ICollection<Products> Products { get; set; }
    }
}