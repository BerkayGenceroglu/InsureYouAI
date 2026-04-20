using InsureYouAI.Context;
using InsureYouAI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace InsureYouAI.Controllers
{
    public class ContactController : Controller
    {
        private readonly InsureContext _context;

        public ContactController(InsureContext context)
        {
            _context = context;
        }

        public IActionResult ContactList()
        {
            ViewBag.Controller = "İletişim";
            ViewBag.Page = "Telefon-Mail-Adres Bilgileri";
            var values = _context.Contacts.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateContact()
        {
            ViewBag.Controller = "İletişim";
            ViewBag.Page = "Telefon-Mail-Adres Bilgileri Ekle";
            return View();
        }

        [HttpPost]
        public IActionResult CreateContact(Contact contact)
        {
            _context.Contacts.Add(contact);
            _context.SaveChanges();
            return RedirectToAction("ContactList");
        }
        [HttpGet]
        public IActionResult UpdateContact(int id)
        {
            ViewBag.Controller = "İletişim";
            ViewBag.Page = "Telefon-Mail-Adres Bilgileri Güncelle";
            var value = _context.Contacts.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateContact(Contact contact)
        {
            _context.Contacts.Update(contact);
            _context.SaveChanges();
            return RedirectToAction("ContactList");
        }

        public IActionResult DeleteContact(int id)
        {
            var value = _context.Contacts.Find(id);
            _context.Contacts.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("ContactList");
        }
    }
}
