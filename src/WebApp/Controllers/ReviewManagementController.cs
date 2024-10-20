﻿using System.Collections;
using PitStop.WebApp.Controllers;

namespace Pitstop.WebApp.Controllers;

public class ReviewManagementController : Controller
{
    //private IReviewManagementAPI _reviewManagementAPI;
    private ICustomerManagementAPI _customerManagementAPI;
    private readonly Microsoft.Extensions.Logging.ILogger _logger;
    private ResiliencyHelper _resiliencyHelper;

    public ReviewManagementController(/*IReviewManagementAPI reviewManagementAPI,*/ ICustomerManagementAPI customerManagementAPI, ILogger<ReviewManagementController> logger)
    {
        //_reviewManagementAPI = reviewManagementAPI;
        _customerManagementAPI = customerManagementAPI;
        _logger = logger;
        _resiliencyHelper = new ResiliencyHelper(_logger);
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        Review review = new Review
        {
            ReviewId = "1",
            Customer = new Customer
            {
                CustomerId = "1",
                Name = "John Doe",
                EmailAddress = "hi@hi.nl"
            },
            Title = "Great service",
            Stars = 5
        };
        
        IEnumerable<Review> reviews = new List<Review> { review };
                    
        return await _resiliencyHelper.ExecuteResilient(async () =>
        {
            var model = new ReviewManagementViewModel
            {
                //Reviews = await _reviewManagementAPI.GetReviews()
                Reviews = reviews
            };
            return View(model);
        }, View("Offline", new ReviewManagementOfflineViewModel()));
    }
    
    [HttpGet]
    public async Task<IActionResult> New()
    {
        return await _resiliencyHelper.ExecuteResilient(async () =>
        {
            var customers = await _customerManagementAPI.GetCustomers();

            var model = new ReviewManagementNewViewModel
            {
                Customers = customers.Select(c => new SelectListItem { Value = c.CustomerId, Text = c.Name })
            };
            return View(model);
        }, View("Offline", new ReviewManagementOfflineViewModel()));
    }
    
    [HttpPost]
    public async Task<IActionResult> New([FromForm] ReviewManagementNewViewModel inputModel)
    {
        return await _resiliencyHelper.ExecuteResilient(async () =>
        {
            //back-end moet nog gemaakt worden en hier geimplementeerd worden.
            
            return RedirectToAction("Index");
        }, View("Offline", new ReviewManagementOfflineViewModel()));
    }
}