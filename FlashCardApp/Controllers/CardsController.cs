using Microsoft.AspNetCore.Mvc;
using FlashCardApp.Data;

namespace FlashCardApp.Controllers
{
    public class CardsController : Controller
    {
        private ApplicationDbContext _context;

        public CardsController(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}