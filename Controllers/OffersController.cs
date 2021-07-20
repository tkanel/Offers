using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Offers.Data;
using Offers.Models;
using Offers.ViewModels;


namespace Offers.Controllers
{
    public class OffersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public OffersController(ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        public async Task<IActionResult> Search()
        {
            var applicationDbContext = _context.Offers.Include(o => o.Company).Include(o => o.Year).Include(o => o.ΟfferUser);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Offers
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Offers.Include(o => o.Company).Include(o => o.Year).Include(o => o.ΟfferUser);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Offers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var offer = await _context.Offers
                .Include(o => o.Company)
                .Include(o => o.Year)
                .Include(o => o.ΟfferUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (offer == null)
            {
                return NotFound();
            }

            return View(offer);
        }

        // GET: Offers/Create
        public IActionResult Create()
        {
            ViewData["CompanyId"] = new SelectList(_context.Companies, "Id", "CompanyName");
            ViewData["YearId"] = new SelectList(_context.Years, "Id", "YearSelected");
            ViewData["ΟfferUserId"] = new SelectList(_context.OfferUsers, "Id", "UserName");
            return View();
        }

        // POST: Offers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateOffer offer)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;
                var db = _context.Years.FirstOrDefault(p => p.Id == offer.YearId);
                var folderName = db.YearSelected;
                //Attachement

                if (offer.FileName != null)
                {
                    //copy file to Attachments folder
                    string uploadsFolder = Path.Combine(_hostEnvironment.WebRootPath, "Files"+"\\"+folderName);
                    uniqueFileName =/* Guid.NewGuid().ToString() + "_" +*/ offer.FileName.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    offer.FileName.CopyTo(new FileStream(filePath, FileMode.Create));

                }
                else
                {

                    uniqueFileName = "no attachement";
                }

                Offer newOffer = new Offer()
                {
                    FileName = uniqueFileName,
                    OpenClose = offer.OpenClose,
                    Notes = offer.Notes,
                    LastUpdate = offer.LastUpdate,
                    CompanyId = offer.CompanyId,
                    ΟfferUserId = offer.ΟfferUserId,
                    YearId = offer.YearId




                };





                _context.Add(newOffer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CompanyId"] = new SelectList(_context.Companies, "Id", "CompanyName", offer.CompanyId);
            ViewData["YearId"] = new SelectList(_context.Years, "Id", "YearSelected", offer.YearId);
            ViewData["ΟfferUserId"] = new SelectList(_context.OfferUsers, "Id", "UserName", offer.ΟfferUserId);
            return View(offer);
        }




        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,FileName,OpenClose,Notes,LastUpdate,CompanyId,ΟfferUserId,YearId")] Offer offer)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(offer);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["CompanyId"] = new SelectList(_context.Companies, "Id", "CompanyName", offer.CompanyId);
        //    ViewData["YearId"] = new SelectList(_context.Years, "Id", "YearSelected", offer.YearId);
        //    ViewData["ΟfferUserId"] = new SelectList(_context.OfferUsers, "Id", "UserName", offer.ΟfferUserId);
        //    return View(offer);
        //}

        // GET: Offers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var offer = await _context.Offers.FindAsync(id);
            if (offer == null)
            {
                return NotFound();
            }
            ViewData["CompanyId"] = new SelectList(_context.Companies, "Id", "CompanyName", offer.CompanyId);
            ViewData["YearId"] = new SelectList(_context.Years, "Id", "YearSelected", offer.YearId);
            ViewData["ΟfferUserId"] = new SelectList(_context.OfferUsers, "Id", "UserName", offer.ΟfferUserId);
            return View(offer);
        }

        // POST: Offers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FileName,OpenClose,Notes,LastUpdate,CompanyId,ΟfferUserId,YearId")] Offer offer)
        {
            if (id != offer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(offer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OfferExists(offer.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CompanyId"] = new SelectList(_context.Companies, "Id", "CompanyName", offer.CompanyId);
            ViewData["YearId"] = new SelectList(_context.Years, "Id", "YearSelected", offer.YearId);
            ViewData["ΟfferUserId"] = new SelectList(_context.OfferUsers, "Id", "UserName", offer.ΟfferUserId);
            return View(offer);
        }

        // GET: Offers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var offer = await _context.Offers
                .Include(o => o.Company)
                .Include(o => o.Year)
                .Include(o => o.ΟfferUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (offer == null)
            {
                return NotFound();
            }

            return View(offer);
        }

        // POST: Offers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var offer = await _context.Offers.FindAsync(id);
            _context.Offers.Remove(offer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OfferExists(int id)
        {
            return _context.Offers.Any(e => e.Id == id);
        }
    }
}
