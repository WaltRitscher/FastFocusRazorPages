using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FastFocusApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TailorMadeTours.Models;

namespace FastFocusApp.Pages
{
  public class DatabindToSingleItemModel : PageModel
  {
    private ApiContext _db
    public DatabindToSingleItemModel(ApiContext db)
    {
      // ApiContext db
      // _db= db;
      // use this to setup dependency injection
    }
    public void OnGet()
    {
      CurrentTourStop = TailorMadeTours.Models.TourSource.TourStops.ElementAt(3);

    }

    public TourStop CurrentTourStop { get; set; }
  }
}