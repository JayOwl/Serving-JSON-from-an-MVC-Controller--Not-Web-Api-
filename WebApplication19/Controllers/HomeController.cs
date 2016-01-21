using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Web.Routing;
using System.Web.Optimization;
using System.Threading.Tasks;
using WebApplication19.Repository;
using Newtonsoft.Json;
using System.Web.Http.Cors;

namespace WebApplication19.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    //config.EnableCors();
    public class HomeController : Controller
    {
        // GET: Home

        public async Task<ActionResult> Manufacturer()
        {
            ManufacturerRepository manufacturerRepo = new ManufacturerRepository();
            var manufacturers = await manufacturerRepo.GetAll();
            //var query = manufacturers.Select(m => new ManufacturerVM { mfg = m.mfg, mfgDiscount = (decimal)m.mfgDiscount });
            var json = JsonConvert.SerializeObject(manufacturers);

            return new ContentResult
            {
                Content = json.ToString(),
                ContentType = "application/json"
            };
        }

        public ActionResult Index()
        {

            return View();
        }
    }
}