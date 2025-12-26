﻿using Microsoft.AspNetCore.Mvc;
using MVCProniaApp.Models;
using MVCProniaApp.ViewModels;
using MVCProniaApp.DAL;

namespace MVCProniaApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM()
            {
                Slides = _context.Sliders.ToList(),
                Products = _context.Products.ToList(),
                Blogs = _context.Blogs.ToList()
            };
            return View(homeVM);
        }
        public IActionResult NotFound()
        {
            return View();
        }
    }
}