using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFoot.Data.Models
{
    public class UrunEkle
    {
        public int FoodID { get; set; }
        public string Name { get; set; }
        public string ShortDesc { get; set; }
                                    // public string LongDesc { get; set; }
                                   // public string ThumbNailImageUrl { get; set; }
        public Double price { get; set; }
        public IFormFile ImageUrl { get; set; }
        
        public int Stock { get; set; }
        public int CatagoryID { get; set; }
        public virtual Catagory Catagory { get; set; }
    }
}
