using Microsoft.AspNetCore.Mvc;
using System;

namespace SkillsTrackerA.Controllers
{
    [Route("/skills")]
    public class SkillsController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            
            string html = "<h1>Skills Tracker</h1>" +
                    "<h2>Coding skills to learn:</h2> " +
                        "<ol>" +
                            "<li>Scala</li>" +
                            "<li>Ruby</li>" +
                            "<li>Basic</li>" +
                        "</ol>";
            return Content(html, "text/html");
    }


        [HttpGet]
        [Route("form")]
        public IActionResult DisplayForm()
        {
            string options =    "<option>learning basics</option>" +
                                "<option>master coder</option>" +
                                "<option>making apps</option>";

            string form =   "<form method='post'>" +
                                "<label>Date:   <input type='date' name='date'/></label></br>" +
                                "<label>Scala:  <select name='Scala'/>" + options + "</select></label></br>" +
                                "<label>Ruby:   <select name='Ruby'/>" + options + "</select></label></br>" +
                                "<label>Basic:  <select name='Basic'/>" + options + "</select></label></br>" +
                                "<input type='submit' value='Submit'/>" +
                            "<form>";

            return Content(form, "text/html");
        }


        [HttpPost]
        [Route("form")]
        public IActionResult DisplayFormResults(DateTime date, string scala, string ruby, string basic)
        {
            string form = "<h1>" + date.ToString("yyyy-MM-dd") + "</h1>" +
                            "<ol>" +
                                "<li>Scala: " + scala + "</li>" +
                                "<li>Ruby: " + ruby + "</li>" +
                                "<li>Basic: " + basic + "</li>" +
                            "</ol>";

            return Content(form, "text/html");
        }


        [HttpPost]
        [Route("table")]
        public IActionResult displayTableResults()
        {
            string table = "";
            return Content(table, "text/html");
        }
    }
}
