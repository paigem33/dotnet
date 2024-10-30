using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FlashCardApp.Data;
using FlashCardApp.Models;

namespace FlashCardApp.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var cards = await _context.Cards.ToListAsync();
            return View(cards);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Card card)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    await _context.Cards.AddAsync(card);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
                catch(Exception e)
                {
                    ModelState.AddModelError(string.Empty, $"Something went wrong {e.Message}");
                }
            }
            ModelState.AddModelError(string.Empty, $"Something went wrong");
            return View(card);
        }
    }
}