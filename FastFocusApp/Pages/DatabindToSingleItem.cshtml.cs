using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TailorMadeTours.Models;

namespace FastFocusApp.Pages
{
  public class DatabindToSingleItemModel : PageModel
  {
    public void OnGet()
    {
      CurrentTourStop = TailorMadeTours.Models.TourSource.TourStops.ElementAt(3);

    }

    public TourStop CurrentTourStop { get; set; }
  }
}