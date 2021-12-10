﻿using Microsoft.AspNetCore.Mvc;
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
                                "<label> Display as List: <input type='radio' name='format' value='List' checked> List</br>" +
                                "<label> Display as Table: <input type='radio' name='format' value='Table'> Table</br>" +
                                "<input type='submit' value='Submit'/>" +
                            "<form>";

            return Content(form, "text/html");
        }


        [HttpPost]
        [Route("form")]
        public IActionResult DisplayFormResults(string format, DateTime date, string scala, string ruby, string basic)
        {
            if(format == "List")
            {
                string form = "<h1>" + date.ToString("yyyy-MM-dd") + "</h1>" +
                            "<ol>" +
                                "<li>Scala: " + scala + "</li>" +
                                "<li>Ruby: " + ruby + "</li>" +
                                "<li>Basic: " + basic + "</li>" +
                            "</ol>";

                return Content(form, "text/html");
            }
            else
            {
                string table = "<h1>" + date.ToString("yyyy-MM-dd") + "</h1>" +
               "<table>" +
                   "<thead>" +
                       "<tr>" +
                           "<th>Scala</th>" +
                           "<th></th>" +
                           "<th>Ruby</th>" +
                           "<th></th>" +
                           "<th>Basic</th>" +
                       "</tr>" +
                   "</thead>" +
                   "<thead>" +
                       "<tr>" +
                           "<td>" + scala + "</td>" +
                           "<td></td>" +
                           "<td>" + ruby + "</td>" +
                           "<td></td>" +
                           "<td>" + basic + "</td>" +
                       "</tr>" +
                   "</tbody>" +
               "</table>";
                return Content(table, "text/html");
            }    
        }


        [HttpPost]
        [Route("table")]
        public IActionResult DisplayTableResults(DateTime date, string scala, string ruby, string basic)
        {
            string table = "<h1>" + date.ToString("yyyy-MM-dd") + "</h1>" +
                "<table>" +
                    "<thead>" +
                        "<tr>" +
                            "<th>Scala</th>" +
                            "<th></th>" +
                            "<th>Ruby</th>" +
                            "<th></th>" +
                            "<th>Basic</th>" +
                        "</tr>" +
                    "</thead>" +
                    "<thead>" +
                        "<tr>" +
                            "<td>" + scala + "</td>" +
                            "<td></td>" +
                            "<td>" + ruby + "</td>" +
                            "<td></td>" +
                            "<td>" + basic + "</td>" +
                        "</tr>" +
                    "</tbody>" +
                "</table>";
            return Content(table, "text/html");
        }
    }
}
