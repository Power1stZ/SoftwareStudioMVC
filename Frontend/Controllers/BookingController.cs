using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Frontend.Models;
using System.Net.Http;

namespace Frontend.Controllers
{
    public class BookingController : Controller
    {
        private readonly ILogger<BookingController> _logger;

        public BookingController(ILogger<BookingController> logger)
        {
            _logger = logger;

        }

        public IActionResult Index()
        {
            ViewData["Page1"] = "select";
            ViewData["Page2"] = "unselect";
            ViewData["Page3"] = "unselect";

            IEnumerable<History> Historys = null;

            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:5001/api/");
                    //HTTP GET
                    var responseTask = client.GetAsync("Historys/61010844");
                    responseTask.Wait();

                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = result.Content.ReadAsAsync<IList<History>>();
                        readTask.Wait();

                        Historys = readTask.Result;
                    }
                    else //web api sent error response 
                    {
                        //log response status here..

                        Historys = Enumerable.Empty<History>();

                        ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                    }
                }

                //Some risky client call that will call parallell code / async /TPL or in some way cause an AggregateException 

            }
            catch (AggregateException err)
            {
                foreach (var errInner in err.InnerExceptions)
                {
                    Debug.WriteLine(errInner); //this will call ToString() on the inner execption and get you message, stacktrace and you could perhaps drill down further into the inner exception of it if necessary 
                }
            }
            Console.WriteLine("pass");
            Console.WriteLine(Historys);
            return View(Historys);
        }

        public IActionResult History()
        {
            ViewData["Page1"] = "unselect";
            ViewData["Page2"] = "unselect";
            ViewData["Page3"] = "select";
            
            
            IEnumerable<History> Historys = null;            
            
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:5001/api/");
                    //HTTP GET
                    var responseTask = client.GetAsync("Historys/61010844");
                    responseTask.Wait();

                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = result.Content.ReadAsAsync<IList<History>>();
                        readTask.Wait();

                        Historys = readTask.Result;
                    }
                    else //web api sent error response 
                    {
                        //log response status here..

                        Historys = Enumerable.Empty<History>();

                        ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                    }
                }

                //Some risky client call that will call parallell code / async /TPL or in some way cause an AggregateException 

            }
            catch (AggregateException err)
            {
                foreach (var errInner in err.InnerExceptions)
                {
                    Debug.WriteLine(errInner); //this will call ToString() on the inner execption and get you message, stacktrace and you could perhaps drill down further into the inner exception of it if necessary 
                }
            }
            Console.WriteLine("pass");
            Console.WriteLine(Historys);
            return View(Historys);
        }

        public IActionResult Overdue()
        {
            ViewData["Page1"] = "unselect";
            ViewData["Page2"] = "select";
            ViewData["Page3"] = "unselect";

            IEnumerable<History> Historys = null;            
            
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:5001/api/");
                    //HTTP GET
                    var responseTask = client.GetAsync("Historys/61010844");
                    responseTask.Wait();

                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = result.Content.ReadAsAsync<IList<History>>();
                        readTask.Wait();

                        Historys = readTask.Result;
                    }
                    else //web api sent error response 
                    {
                        //log response status here..

                        Historys = Enumerable.Empty<History>();

                        ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                    }
                }

                //Some risky client call that will call parallell code / async /TPL or in some way cause an AggregateException 

            }
            catch (AggregateException err)
            {
                foreach (var errInner in err.InnerExceptions)
                {
                    Debug.WriteLine(errInner); //this will call ToString() on the inner execption and get you message, stacktrace and you could perhaps drill down further into the inner exception of it if necessary 
                }
            }
            Console.WriteLine("pass");
            Console.WriteLine(Historys);
            return View(Historys);
        }
    }
}