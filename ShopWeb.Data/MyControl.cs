using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWeb.Data
{
    public class MyControl
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Info { get; set; }

        public double Price { get; set; }

        public byte[] Img { get; set; }

        public string ImgStr { get; set; }

        public string Content { get; set; }

        public DateTime? Date { get; set; }
    }
}
