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
    [BindProperty]
    public TourStop CurrentTourStop { get; set; }
  }
}