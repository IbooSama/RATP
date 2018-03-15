using System;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace RATP.Controllers
{
    public class FormController
    {
        // POST
        public IActionResult FormOne(Models.ItineraryFormData formData)
        {
            return new RedirectToActionResult("Result", "Home", formData);
        }
    }
}
