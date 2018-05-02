using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FastFocusApp.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FastFocusApp
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {

      services.AddDbContext<ApiContext>(opt => opt.UseInMemoryDatabase("FastFocusRazorPages"));
      services.AddMvc();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env,IServiceProvider serviceProvider )
    {
      if (env.IsDevelopment())
      {
        app.UseBrowserLink();
        app.UseDeveloperExceptionPage();
      }
      else
      {
        app.UseExceptionHandler("/Error");
      }

      app.UseStaticFiles();
      // add the datacontext
      var context = serviceProvider.GetService<ApiContext>();
      AddTestData(context);
      app.UseMvc();
    }
    private static void AddTestData(ApiContext currentDbContext)
    {
      //if (currentDbContext.TourStops.Count()>0)
      //{
      //  currentDbContext.RemoveRange(currentDbContext.TourStops.Where(x=>x.Name != null));
      //  currentDbContext.SaveChanges();
      //}
      //currentDbContext.TourStops.AddRange(TailorMadeTours.Models.TourSource.TourStops);
    }
    }
}
