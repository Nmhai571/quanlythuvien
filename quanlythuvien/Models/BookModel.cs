using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlythuvien.Models
{
    public class BookModel
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
        public DateTime YearOfpublication { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }
        public int PublisherId { get; set; }
        public byte[] BookImage { get; set; }

    }
}
