using DiaryApp.Data;
using DiaryApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DiaryApp.Controllers
{
    public class DiaryEntriesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DiaryEntriesController(ApplicationDbContext db)
        {
            _db = db;
            
        }

        
        public IActionResult Index()
        {
            List<DiaryEntry> entries = _db.DiaryEntries.ToList();
            return View(entries);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create (DiaryEntry obj)
        {
            if (obj != null && obj.Title.Length < 3) {
                ModelState.AddModelError("Title", "Title too short");
            }

            if (ModelState.IsValid)
            {
                _db.DiaryEntries.Add(obj);  // Adds the new diary entry to the database
                _db.SaveChanges(); // Saves the changes to the database
                return RedirectToAction("Index", "DiaryEntries");
                // Return to Home Controller's index action after form submission
            }

            return View(obj);
        }

        [HttpGet]
        public IActionResult Edit (int? id)
        {
            if (id == null) { 
                return NotFound(); // the 404 page
            }

            DiaryEntry? diaryEntry = _db.DiaryEntries.Find(id);

            if (diaryEntry == null)
            {
                return NotFound();
            }

            return View(diaryEntry);
        }


        [HttpPost]

        public IActionResult Edit(DiaryEntry obj)
        {
            if (obj != null && obj.Title.Length < 3)
            {
                ModelState.AddModelError("Title", "Title too short");
            }

            if (ModelState.IsValid)
            {
                _db.DiaryEntries.Update(obj);  // Updates the new diary entry in the database
                _db.SaveChanges(); // Saves the changes to the database
                return RedirectToAction("Index", "DiaryEntries");
                // Return to Home Controller's index action after form submission
            }

            return View(obj);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound(); // the 404 page
            }

            DiaryEntry? diaryEntry = _db.DiaryEntries.Find(id);

            if (diaryEntry == null)
            {
                return NotFound();
            }

            return View(diaryEntry);
        }


        [HttpPost]

        public IActionResult Delete(DiaryEntry obj)
        {

                _db.DiaryEntries.Remove(obj);  // Remove the new diary entry from the database
                _db.SaveChanges(); // Saves the changes to the database
                return RedirectToAction("Index", "DiaryEntries");
                // Return to Home Controller's index action after form submission

        }

    }
}
