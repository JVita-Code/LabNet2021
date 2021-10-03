using LabNet2021.Tp8.API_MVC_FINAL.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LabNet2021.Tp8.API_MVC_FINAL.Controllers
{
    public class CharactersController : Controller
    {
        string Baseurl = "http://hp-api.herokuapp.com/";
        public async Task<ActionResult> Index()
        {
            List<Characters> CharInfo = new List<Characters>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage Res = await client.GetAsync("api/characters");

                if (Res.IsSuccessStatusCode)
                {
                    var CharResponse = Res.Content.ReadAsStringAsync().Result;
                    CharInfo = JsonConvert.DeserializeObject<List<Characters>>(CharResponse);
                }
                return View(CharInfo);
            }
        }
    }
}