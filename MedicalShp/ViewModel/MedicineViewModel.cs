using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MedicalShp.ViewModel
{
    public class MedicineViewModel
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Brand { get; set; }

        public int Price { get; set; }

        public int Quantity { get; set; }

        [DisplayName("Expiry Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime ExpiryDate { get; set; }

        public string BgColor { get; set; }
    }
}