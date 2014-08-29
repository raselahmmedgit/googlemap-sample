using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RnD.GoogleMapSample.Models;

namespace RnD.GoogleMapSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Basic()
        {
            return View();
        }

        public ActionResult Load()
        {
            return View();
        }

        public ActionResult LoadDdl()
        {
            return View();
        }

        public JsonResult GetDataList(int id)
        {
            var googleMapViewModelList = new List<GoogleMapViewModel>
                            {
                                new GoogleMapViewModel { Latitude = "24.100000000000", Longitude ="89.233333330000", Message = "Pabna, Atgharia, Bangladesh."},
                                new GoogleMapViewModel { Latitude = "24.083333330000", Longitude ="89.616666670000", Message = "Pabna, Bera, Bangladesh."},
                                new GoogleMapViewModel { Latitude = "23.327500000000", Longitude ="89.495833330000", Message = "Pabna, Bhangura, Bangladesh."},
                                new GoogleMapViewModel { Latitude = "24.230000000000", Longitude ="89.300000000000", Message = "Pabna, Chatmohar, Bangladesh."},
                                new GoogleMapViewModel { Latitude = "23.600000000000", Longitude ="89.833333330000", Message = "Pabna, Faridpur, Bangladesh."}
                            };

            return Json(googleMapViewModelList, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetDistrictList(int id)
        {
            var googleMapViewModelList = new List<GoogleMapViewModel>
                            {
                                new GoogleMapViewModel { Latitude = "23.710277780000", Longitude ="90.407222220000", Message = "Dhaka, Bangladesh."},
                                new GoogleMapViewModel { Latitude = "23.833333330000", Longitude ="88.916666670000", Message = "Kushtia, Bangladesh."},
                                new GoogleMapViewModel { Latitude = "22.333333330000", Longitude ="90.333333330000", Message = "Patuakhali, Bangladesh."}
                            };

            return Json(googleMapViewModelList, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetUpazilaList(int id)
        {
            var googleMapViewModelList = new List<GoogleMapViewModel>
                            {
                                new GoogleMapViewModel { Latitude = "24.100000000000", Longitude ="89.233333330000", Message = "Pabna, Atgharia, Bangladesh."},
                                new GoogleMapViewModel { Latitude = "24.083333330000", Longitude ="89.616666670000", Message = "Pabna, Bera, Bangladesh."},
                                new GoogleMapViewModel { Latitude = "23.327500000000", Longitude ="89.495833330000", Message = "Pabna, Bhangura, Bangladesh."},
                                new GoogleMapViewModel { Latitude = "24.230000000000", Longitude ="89.300000000000", Message = "Pabna, Chatmohar, Bangladesh."},
                                new GoogleMapViewModel { Latitude = "23.600000000000", Longitude ="89.833333330000", Message = "Pabna, Faridpur, Bangladesh."}
                            };

            return Json(googleMapViewModelList, JsonRequestBehavior.AllowGet);
        }
    }
}
