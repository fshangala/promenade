using System;
using Microsoft.AspNetCore.Mvc;
using Promenade.Data;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace Promenade.Controllers
{
    public class CategoryController: Controller
    {
        private readonly PromenadeContext _context;

        public CategoryController(PromenadeContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? id)
        {
            var qfoods = from m in _context.Food select m;
            if (id == null)
            {
                var foods = await _context.Food.ToListAsync();
                ViewData["foods"] = foods;
            }
            else
            {
                var category = await _context.Category.FindAsync(id);
                if (category == null)
                {
                    return NotFound();
                }
                var foods = qfoods.Where(x => x.Category == category.Id).ToList();
                ViewData["foods"] = foods;
            }
            return View();
        }
    }
}