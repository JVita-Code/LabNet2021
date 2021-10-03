using LabNet2021.Tp8.API_MVC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LabNet2021.Tp8.API_MVC.Controllers
{
    public class HomeController : Controller
    {
        string Baseurl = "http://hp-api.herokuapp.com/";
        public async Task<ActionResult> Index()
        {
            List<Character> CharInfo = new List<Character>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage Res = await client.GetAsync("api/characters");

                if (Res.IsSuccessStatusCode)
                {
                    var CharResponse = Res.Content.ReadAsStringAsync().Result;
                    CharInfo = JsonConvert.DeserializeObject<List<Character>>(CharResponse);
                }
                return View(CharInfo);
            }
        }
    }
}