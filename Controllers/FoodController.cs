using System;
using Microsoft.AspNetCore.Mvc;
using Promenade.Data;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace Promenade.Controllers
{
    public class FoodController: Controller
    {
        private readonly PromenadeContext _context;

        public FoodController(PromenadeContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var food = await _context.Food.FindAsync(id);
            if (food == null)
            {
                return NotFound();
            }

            var category = await _context.Category.FindAsync(food.Category);
            var qfoods = from m in _context.Food select m;
            var foods = qfoods.Where(x => x.Category == category.Id).ToList();

            ViewData["FoodName"] = food.Name;
            ViewData["Category"] = category.Name;
            ViewData["FoodPrice"] = food.Price;
            ViewData["FoodImage"] = food.Image;

            ViewData["foods"] = foods;
            
            return View();
        }
    }
}