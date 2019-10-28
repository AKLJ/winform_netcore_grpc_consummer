using System;
using System.Collections.Generic;
using System.Text;

namespace WNGC.Stocks.Models
{
    public class Article
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public Company Company { get; set; }
    }
}
