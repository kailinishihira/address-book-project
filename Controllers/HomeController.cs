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

    [HttpPost("/contacts/clear")]
        public ActionResult ClearContacts()
        {
            Contact.ClearAll();
            return View();
        }

    [HttpPost("/contact/remove/{id}")]
        public ActionResult RemoveContact(int id)
        {
            Contact contact = Contact.Find(id);
            contact.RemoveThis(contact);
            return View(contact);
        }

    [HttpGet("/contact/add")]
        public ActionResult AddContact()
        {
            return View();
        }

    [HttpPost("/contact/new")]
        public ActionResult NewContact()
        {
            string name = Request.Form["new-name"];
            string phoneNumber = Request.Form["new-phone-number"];
            string address = Request.Form["new-address"];
            Contact newContact = new Contact(name, phoneNumber, address);
            return View(newContact);
        }

    [HttpGet("/contact/{id}")]
        public ActionResult ContactDetails(int id)
        {
            Contact contact = Contact.Find(id);
            return View(contact);
        }

  }
}
