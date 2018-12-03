﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TailorMadeTours.Models;

namespace FastFocusApp.Pages
{
  public class EditTourStopModel : PageModel
  {
    public void OnGet(int id)
    {
      CurrentTourStop = TailorMadeTours.Models.TourSource.TourStops.ElementAt(id);

    }


    public IActionResult OnPost()
    {
      if (!ModelState.IsValid)
      {
        return Page();
        
      }
      // how do we pass data (message) back to the orginal page?
      // use a property on the page model
      Message = $"Tour Stop: '{CurrentTourStop.Name}' was updated!";
      // Response.Redirect("./Index");
     return RedirectToPage("DatabindWithRouteParam");
      // similar to RedirectToAction and RedirectToRoute
    }

    // use TempData attribute to pass data between pages
    // available in controllers and razor pages
    // Properties marked with TempData attribute are stored in encrypted cookie
    // When the data is read from the cookie, it is deleted.

    // in this example the Message property is 
    // defined in two pages, so it can be shared.
    [TempData]
    public string Message { get; set; }


    [BindProperty]
    public TourStop CurrentTourStop { get; set; }
  }
}