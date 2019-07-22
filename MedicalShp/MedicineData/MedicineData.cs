using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MedicalShp.Models;

namespace MedicalShp.MedicineData
{
    public static class MedicineData
    {
        public static IList<Medicine> GetMedicineData()
        {
            return (IList<Medicine>)new List<Medicine>()
      {
        new Medicine()
        {
          ID = 1,
          Brand = "Cipla",
          ExpiryDate = DateTime.Today,
          Name = "Crocine",
          Price = 20,
          Quantity = 20
        },
        new Medicine()
        {
          ID = 2,
          Brand = "Cipla2",
          ExpiryDate = DateTime.Today,
          Name = "Crocine",
          Price = 20,
          Quantity = 12
        },
        new Medicine()
        {
          ID = 3,
          Brand = "Cipla3",
          ExpiryDate = DateTime.Today,
          Name = "Crocine",
          Price = 5,
          Quantity = 10
        },
        new Medicine()
        {
          ID = 4,
          Brand = "Cipla4",
          ExpiryDate = DateTime.Today,
          Name = "Crocine",
          Price = 20,
          Quantity = 5
        },
        new Medicine()
        {
          ID = 5,
          Brand = "Cipla5",
          ExpiryDate = DateTime.Today,
          Name = "Crocine5",
          Price = 20,
          Quantity = 30
        },
        new Medicine()
        {
          ID = 6,
          Brand = "Cipla6",
          ExpiryDate = DateTime.Today,
          Name = "Crocine6",
          Price = 2,
          Quantity = 35
        },
        new Medicine()
        {
          ID = 7,
          Brand = "Cipla7",
          ExpiryDate = DateTime.Today,
          Name = "Crocine7",
          Price = 20,
          Quantity = 10
        },
        new Medicine()
        {
          ID = 8,
          Brand = "Cipla8",
          ExpiryDate = DateTime.Today,
          Name = "Crocine8",
          Price = 20,
          Quantity = 21
        },
        new Medicine()
        {
          ID = 9,
          Brand = "Cipla9",
          ExpiryDate = DateTime.Today,
          Name = "Crocine9",
          Price = 20,
          Quantity = 23
        },
        new Medicine()
        {
          ID = 10,
          Brand = "Cipla10",
          ExpiryDate = DateTime.Today,
          Name = "Crocine10",
          Price = 20,
          Quantity = 21
        },
        new Medicine()
        {
          ID = 11,
          Brand = "Cipla11",
          ExpiryDate = DateTime.Today,
          Name = "Crocine11",
          Price = 20,
          Quantity = 23
        },
        new Medicine()
        {
          ID = 12,
          Brand = "Cipla12",
          ExpiryDate = DateTime.Today,
          Name = "Crocine12",
          Price = 20,
          Quantity = 23
        }
      };
        }
    }
}