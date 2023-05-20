using AutoMapper;
using BusinessLayer.Abstract;
using DTOLayer.DTOs.ContactDTOs;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Traversal.Controllers
{
    public class ContactUsController : Controller
    {
        private readonly IContactUsService _contactUsService;
        private readonly IMapper _mapper;

        public ContactUsController(IContactUsService contactUsService, IMapper mapper)
        {
            _contactUsService = contactUsService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(SendMessageDTO model)
        {
            if(ModelState.IsValid)
            {
                _contactUsService.TAdd(new ContactUs()
                {
                    Mail = model.Mail,
                    Subject = model.Subject,
                    MessageBody = model.MessageBody,  
                    Name = model.Name,
                    MessageDate = Convert.ToDateTime(DateTime.Now.ToShortDateString()),
                    Status =true
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }

        

    }
}
