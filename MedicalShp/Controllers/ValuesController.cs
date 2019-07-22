using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MedicalShp.Models;
using MedicalShp.MedicineData;
namespace MedicalShp.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IHttpActionResult Get()
        {
            var medicineData = MedicineData.MedicineData.GetMedicineData();
            return Ok(medicineData);
        }

        // GET api/values/5
        public IHttpActionResult Get(int id)
        {
            Medicine content = MedicineData.MedicineData.GetMedicineData().FirstOrDefault((x => x.ID == id));
            if (content == null)
            {
                return Content(HttpStatusCode.NotFound, "No records found");
            }
            else
            {
                return Ok(content);
            }
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {

        }
    }
}
