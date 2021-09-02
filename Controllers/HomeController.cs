﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Net.Http.Headers;
using Offers.Data;
using Offers.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Offers.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ReadAllFilesFromDirectory()
        {
            List<string> fileName = new List<string>();
            string sourceDirectory = @"C:\Users\Thodoris\Downloads";

            var txtFiles = Directory.EnumerateFiles(sourceDirectory, "*.exe", SearchOption.AllDirectories);

            foreach (var currentFile in txtFiles)
            {


                fileName.Add(currentFile.Substring(sourceDirectory.Length + 1));

                //Directory.Move(currentFile, Path.Combine(outputDirectory, fileName));
            }
            ViewBag.FileName = fileName;

            return View(_context.FileName);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ReadAllFilesFromDirectory(FileName file)
        {

            if (ModelState.IsValid)
            {

               // file.isInserted = true;
                _context.Add(file);
                    await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));





            }
            return View(file);

                        
        }





        //Stream bytes to a file
        public FileStreamResult CreateFile()
        {

            var stream = new MemoryStream(Encoding.UTF8.GetBytes("Hello World ΜΑΛΑΚΑ"));

            return new FileStreamResult(stream, new MediaTypeHeaderValue("text/plain"))
            {

                FileDownloadName = "test.txt"

            };


        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
