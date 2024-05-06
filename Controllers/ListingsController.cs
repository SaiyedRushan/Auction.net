using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Auction.net.Data;
using Auction.net.Models;
using Auction.net.Data.Services;
using Microsoft.AspNetCore.Hosting;

namespace Auction.net.Controllers
{
    public class ListingsController : Controller
    {
        private readonly IListingsService _listingsService;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ListingsController(IListingsService listingsService, IWebHostEnvironment webHostEnvironment)
        {
            _listingsService = listingsService;
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: Listings
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _listingsService.GetAll(); 
            return View(await applicationDbContext.ToListAsync());
        }

        //// GET: Listings/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null || _context.Listings == null)
        //    {
        //        return NotFound();
        //    }

        //    var listing = await _context.Listings
        //        .Include(l => l.User)
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (listing == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(listing);
        //}

        //// GET: Listings/Create
        //public IActionResult Create()
        //{
        //    ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id");
        //    return View();
        //}

        //// POST: Listings/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,Title,Description,Price,ImagePath,IsSold,IdentityUserId")] Listing listing)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(listing);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", listing.IdentityUserId);
        //    return View(listing);
        //}

     
    }
}
