using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Promenade.Data;
using Promenade.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using System.Web;
using Microsoft.AspNetCore.Hosting;
using System.Linq;

namespace Promenade.Controllers
{
    public class AdminController: Controller
    {
        private readonly PromenadeContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public AdminController(PromenadeContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Category.ToListAsync());
        }

        //View foods
        public async Task<IActionResult> Food(int? id)
        {
            var qfoods = from m in _context.Food select m;
            if (id == null)
            {
                var foods = await _context.Food.ToListAsync();
                return View(foods);
            }
            else
            {
                var category = await _context.Category.FindAsync(id);
                if (category == null)
                {
                    return NotFound();
                }
                var foods = qfoods.Where(x => x.Category == category.Id).ToList();
                return View(foods);
            }
                
        }

        //Delete Food
        public async Task<IActionResult> DeleteFood(int? id)
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
            else
            {
                var file = food.Image;
                string webRootPath = _webHostEnvironment.WebRootPath;
                var path = webRootPath+file;
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }
                _context.Entry(food).State = EntityState.Deleted;
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
        }

        //Edit food
        public async Task<IActionResult> EditFood(int? id)
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
            return View(food);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditFood(int id, [Bind("Id,Category,Name,Price,Image")] Food food)
        {
            if (id != food.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(food);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    var fd = await _context.Food.FindAsync(food.Id);
                    if (fd == null)
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(food);
        }

        //Create food
        public async Task<IActionResult> CreateFood()
        {
            ViewData["categories"] = await _context.Category.ToListAsync();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateFood(IFormFile ImageFile, [Bind("Category,Name,Price")] Food food)
        {
            if (ModelState.IsValid)
            {
                if(ImageFile == null){
                    return RedirectToAction("CreateFood");
                }
                string webRootPath = _webHostEnvironment.WebRootPath;
                var filePath = "/media/food/"+ImageFile.FileName;
                var path = webRootPath+"/media/food/"+ImageFile.FileName;
                using (var stream = System.IO.File.Create(path))
                {
                    await ImageFile.CopyToAsync(stream);
                }
                food.Image = filePath;
                
                _context.Add(food);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return RedirectToAction("CreateFood");
        }

        //Edit category
        public async Task<IActionResult> EditCategory(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Category.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditCategory(int id, [Bind("Id,Name,Image")] Category category)
        {
            if (id != category.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(category);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    var cat = await _context.Category.FindAsync(category.Id);
                    if (cat == null)
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(category);
        }

        //Create category
        public async Task<IActionResult> CreateCategory()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateCategory(IFormFile ImageFile, [Bind("Name")] Category category)
        {
            string webRootPath = _webHostEnvironment.WebRootPath;
            var path = webRootPath+"/media/category/"+ImageFile.FileName;
            using (var stream = System.IO.File.Create(path))
            {
                await ImageFile.CopyToAsync(stream);
            }
            category.Image = path;
            
            _context.Add(category);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
                
            //return View(category);
        }

        //Delete Category
        public async Task<IActionResult> DeleteCategory(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Category.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            else
            {
                var file = category.Image;
                string webRootPath = _webHostEnvironment.WebRootPath;
                var path = webRootPath+file;
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }
                _context.Entry(category).State = EntityState.Deleted;
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
        }

        public IActionResult Manue()
        {
            return View();
        }
    }
}