using MedicalShp.Models;
using MedicalShp.ViewModel;
using PagedList;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Web.Mvc;

namespace MedicalShp.Controllers
{
    public class HomeController : Controller
    {
        [HandleError]
        public ActionResult Index(string searchText, int? page, string sortBy)
        {
            ViewBag.IdColSort = string.IsNullOrEmpty(sortBy) ? "Id desc" : "";
            IEnumerable<MedicineViewModel> source = null;
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("http://localhost:56590//api/");
                HttpResponseMessage result = httpClient.GetAsync("values").Result;
                if (result.IsSuccessStatusCode)
                {
                    source = result.Content.ReadAsAsync<IList<MedicineViewModel>>().Result;
                    IEnumerable<MedicineViewModel> medicineViewModels = this.Session["medicineData"] as IEnumerable<MedicineViewModel>;
                    if (medicineViewModels == null)
                        this.Session["medicineData"] = (object)source;
                    else
                        source = medicineViewModels;
                }
            }
            if (!string.IsNullOrEmpty(searchText))
                source = source.Where(x => x.Name.Equals(searchText, StringComparison.CurrentCultureIgnoreCase));
            //IEnumerable<MedicineViewModel> superset = sortBy == "Id desc" ? source.OrderByDescending<MedicineViewModel, int>((Func<MedicineViewModel, int>)(x => x.ID)) : (IEnumerable<MedicineViewModel>)source.OrderBy<MedicineViewModel, int>((Func<MedicineViewModel, int>)(x => x.ID));
            foreach (MedicineViewModel medicineViewModel in source)
            {
                medicineViewModel.BgColor = medicineViewModel.Quantity >= 10 ? "white" : "yellow";
                if (medicineViewModel.ExpiryDate.Subtract(DateTime.Today).Days > 30)
                {

                }
            }

            switch (sortBy)
            {
                case "Id desc":
                    source = source.OrderByDescending(x => x.ID);
                    break;
                default:
                    source = source.OrderBy(x => x.ID);
                    break;
            }

            source = source.ToPagedList(page ?? 1, 10);
            return View((IPagedList<MedicineViewModel>) source);
        }

        public ActionResult Edit(int id)
        {
            var model = Session["medicineData"] as IEnumerable<MedicineViewModel>;
            var viewModel = model.FirstOrDefault((x => x.ID == id));
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Edit(Medicine medicine)
        {
            if (this.ModelState.IsValid)
            {
                IEnumerable<MedicineViewModel> source = this.Session["medicineData"] as IEnumerable<MedicineViewModel>;
                MedicineViewModel medicineViewModel = source.FirstOrDefault((x => x.ID == medicine.ID));
                medicineViewModel.Brand = medicine.Brand;
                medicineViewModel.ExpiryDate = medicine.ExpiryDate;
                medicineViewModel.Name = medicine.Name;
                medicineViewModel.Price = medicine.Price;
                medicineViewModel.Quantity = medicine.Quantity;
                this.Session["medicineData"] = (object)source;
                return RedirectToAction("Index");
            }
            else
            {
                var model = new MedicineViewModel()
                {
                    ID = medicine.ID,
                    Brand = medicine.Brand,
                    ExpiryDate = medicine.ExpiryDate,
                    Name = medicine.Name,
                    Price = medicine.Price,
                    Quantity = medicine.Quantity
                };

                return View(model);
            }
        }
    }
}
