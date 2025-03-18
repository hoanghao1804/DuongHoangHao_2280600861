using DuongHoangHao_2280600861.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DuongHoangHao_2280600861.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class ProductAdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
