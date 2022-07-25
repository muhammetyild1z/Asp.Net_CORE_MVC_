using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFoot.Data.Models
{
    public class Catagory
    {
        public int CatagoryID { get; set; }
        [Required(ErrorMessage ="Katagori Adı Boş Geçilemez.")]
        [StringLength(20 , ErrorMessage ="Katagori 4-20 karakter olabilir.",MinimumLength =4)]
        public String CatagoryName { get; set; }
      //  [Required(ErrorMessage = "Katagori Açıklaması Boş Geçilemez.")]
        public String CatagoryDesc { get; set; }
   
        public bool Status { get; set; }

        public List<Food> Foods { get; set; }
    }
}
