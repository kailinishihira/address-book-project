using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;

namespace AddressBook.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
        public ActionResult Index()
        {
            List<Contact> allContacts = Contact.GetAll();
            return View(allContacts);
        }
    [HttpGet("/contact/add")]
        public ActionResult AddContact()
        {
            return View();
        }

    [HttpPost("/contact/show")]
        public ActionResult ShowContact()
        {
            string name = Request.Form["new-name"];
            string phoneNumber = Request.Form["new-phone-number"];
            string address = Request.Form["new-address"];
            Contact newContact = new Contact(name, phoneNumber, address);

            return View(newContact);
        }
  }
}
