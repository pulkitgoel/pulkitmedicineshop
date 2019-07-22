using MedicalShp.Filter;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MedicalShp.Models
{
    public class Medicine
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Medicine name is required")]
        [DisplayName("Medicine Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Brand name is required")]
        public string Brand { get; set; }

        [Required(ErrorMessage = "Price is required")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Quantity is required")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Expiry date is required")]
        [DisplayName("Expiry Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [DateAttribute]
        public DateTime ExpiryDate { get; set; }
    }
}