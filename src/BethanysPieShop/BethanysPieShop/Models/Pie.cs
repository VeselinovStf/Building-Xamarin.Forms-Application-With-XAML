using System;
using System.Collections.Generic;
using System.Text;

namespace BethanysPieShop.Models
{
    public class Pie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageURI { get; set; }

        public double Price { get; set; }

        public bool InStock { get; set; }
    }
}
