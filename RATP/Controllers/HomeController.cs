using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using RATP.Models;

using Newtonsoft.Json;  
using System.Net.Http;  
using System.Net.Http.Headers;  
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Json;
using Newtonsoft.Json.Linq;

namespace RATP.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            String json = "";
            List<Line> lines = new List<Line>();
            using (var webClient = new System.Net.WebClient())
            {
                json = webClient.DownloadString("https://api-ratp.pierre-grimaud.fr/v3/lines/metros");

                dynamic result = JsonValue.Parse(json);

                ViewData["json"] = result["result"]["metros"];
                Console.WriteLine("toto");
                Console.WriteLine(result["result"]["metros"][0]["name"]);
               /* foreach (var line in result["result"]["metros"]) {
                    lines.Add(new Line(line["name"], line["id"], line["code"], line["directions"]));
                }*/

                Console.WriteLine(lines.Count());
            }
            return View(lines);
        }
    }
}
