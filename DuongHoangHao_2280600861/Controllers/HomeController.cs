using System.Diagnostics;
using DuongHoangHao_2280600861.Models;
using DuongHoangHao_2280600861.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DuongHoangHao_2280600861.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;

        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        // Hi?n th? danh sách s?n ph?m
        public async Task<IActionResult> Index()
        {
            var products = await _productRepository.GetAllAsync();
            return View(products);
        }

        private readonly ILogger<HomeController> _logger;
    }
}
