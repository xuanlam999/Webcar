using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarShowroom.Models;

namespace CarShowroom.Areas.Admin.Controllers
{
    public class DonHangController : Controller
    {
        // GET: DonHang
        public ActionResult Index()
        {
            CarShowroomDbContext DbContext = new CarShowroomDbContext();
            var list = DbContext.HoaDon.ToList();
            return View(list);
        }
        //  Details

        //https://localhost:44353/DonHang/Details/3
        [HttpGet]
        public ActionResult Details(int id)
        {
            CarShowroomDbContext DbContext = new CarShowroomDbContext();
            var list = DbContext.ChiTietHoaDon.Where(p=>p.MaHoaDon == id).ToList();
            return View(list);
        }
    }
}