using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TailorMadeTours.Models;

namespace FastFocusApp.Pages
{
    public class DatabindWithRouteParamModel : PageModel
    {
    public void OnGet(int id)
    {
      CurrentTourStop = TailorMadeTours.Models.TourSource.TourStops.ElementAt(id);

    }

    // use TempData attribute to pass data between pages
    // Properties marked with TempData
    // attribute  are stored in encrypted cookie
    // When the data is read from the cookie, it is deleted.

     // in this example the Message property is 
     // defined in two pages, so it can be shared.
    [TempData]
    public string Message { get; set; }


    public bool ShouldShowMessage => !String.IsNullOrEmpty(Message);
   [BindProperty]
    public TourStop CurrentTourStop { get; set; }
  }
}