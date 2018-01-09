using DutchTreat.Data;
using DutchTreat.Services;
using DutchTreat.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DutchTreat.Controllers
{
    public class AppController:Controller
    {
        private readonly IMailService _mailService;
        private readonly IDutchRepository _repository;
        //private readonly DutchContext _context;

        public AppController(IMailService mailService, IDutchRepository repository)
        {
            _mailService = mailService;
            _repository = repository;
            //_context = context;
        }

        public IActionResult Index()
        {
            return RedirectToAction("Shop", "App");
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            ViewBag.Title = "Contact Us";
            return View();
        }

        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                //Send the email via dummy mail service
                _mailService.SendMessage("jackyguan007@gmail.com",
                    model.Subject,
                    $"From: {model.Name} - {model.Email}, Message: {model.Message}");
                ViewBag.UserMessage = "Mail Sent";
                ModelState.Clear();

            }
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Title = "About Us";
            return View();
        }

        public IActionResult Shop()
        {
            //var results = _context.Products
            //   .OrderBy(p => p.Category)
            //   .ToList();
            //Or use LINQ:
            //var results = from p in _context.Products
            //              orderby p.Category
            //              select p;

            //var results = _repository.GetAllProducts();
            //return View(results);

            return View();
        }
    }
}
