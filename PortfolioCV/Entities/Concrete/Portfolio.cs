using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Portfolio : BaseEntity
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string ImageUrl2 { get; set; }
        public string ProjectUrl { get; set; }
        public string Platform { get; set; }
        public string Price { get; set; }
        public bool Status { get; set; }
        public int Value { get; set; }
    }
}