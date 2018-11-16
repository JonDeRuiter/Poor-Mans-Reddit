using API_Lab_Matt_Colville.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace API_Lab_Matt_Colville.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Colville()
        {
            HttpWebRequest request = WebRequest.CreateHttp("https://www.reddit.com/r/mattcolville/.json");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader rd = new StreamReader(response.GetResponseStream());
            string data = rd.ReadToEnd();

            JObject redditJson = JObject.Parse(data);

            ViewBag.data = redditJson["data"]["children"][0]["data"]["title"];
            ViewBag.image = redditJson["data"]["children"][0]["data"]["thumbnail"];
            ViewBag.source = redditJson["data"]["children"][0]["data"]["url"];
            ViewBag.permalink = redditJson["data"]["children"][0]["data"]["permalink"];
            
            
            return View();
        }
    }
}