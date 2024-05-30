using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace Ch10SkillsTracker;

[Route("/skills")]
public class SkillsController : Controller
{
    // Print-friendly text
    Dictionary<string, string> progressOptions = new() {
        { "learningBasics", "Learning the basics"},
        { "buildingApps", "Building some apps"},
        { "masterCoder", "Master coder" }
    };

    // Endpoint: GET /skills
    [HttpGet] // defaults to base route for controller
    public IActionResult RenderSkillsPage()
    {
        string html = 
            "<h1>Skills Tracker</h1>" +
            "<h2>Coding Skills to Learn</h2>" +
            "<ol>" +
            "<li>C#</li>" +
            "<li>JavaScript</li>" +
            "<li>Ruby</li>" +
            "</ol>" +
            "<p>Click <a href='/skills/form'>here</a> to update your learning progress.</p>";

        return Content(html, "text/html");
    }

    // Endpoint: GET /skills/form
    [HttpGet("form")]
    public IActionResult RenderSkillsForm()
    {
        StringBuilder optionsHTML = new();
        foreach(KeyValuePair<string, string> option in progressOptions)
        {
            optionsHTML
                .Append("<option value='")
                .Append(option.Key)
                .Append("'>")
                .Append(option.Value)
                .Append("</option>");
        }

        string html = 
            // BONUS MISSION 2 - Post to /results instead of /form
            "<form action='/skills/results' method='POST'>" +
            "<label>Today's Date:</label>" +
            "<input type='date' name='updated' /><br />" +
            "<label>C# Progress:</label>" +
            "<select name='cSharpProgress'>" +
            optionsHTML +
            "</select><br />" +
            "<label>JavaScript Progress:</label>" +
            "<select name='jSProgress'>" +
            optionsHTML +
            "</select><br />" +
            "<label>Ruby Progress:</label>" +
            "<select name='rubyProgress'>" +
            optionsHTML +
            "</select><br />" +
            "<button type='submit'>Submit</button>" +
            "</form>";

        return Content(html, "text/html");
    }

    // Endpoint: POST /skills/form
    // This is no longer used after bonus mission
    [HttpPost("form")]
    public IActionResult ProcessSkillsForm(string updated, string cSharpProgress, string jSProgress, string rubyProgress)
    {
        string html = 
            "<h1>" + updated + "</h1>" +
            "<h3>My Progress</h3>" +
            "<ol>" +
            "<li>C#: " + progressOptions[cSharpProgress] + "</li>" +
            "<li>JavaScript: " + progressOptions[jSProgress] + "</li>" +
            "<li>Ruby: " + progressOptions[rubyProgress] + "</li>" +
            "</ol>";

        return Content(html, "text/html");
    }

    // Endpoint: POST /skills/results
    // BONUS MISSION 1 - Use table instead of ordered list
    // BONUS MISSION 2 - Route to /results instead of /form
    [HttpPost("results")]
    public IActionResult ProcessSkillsFormBonus(string updated, string cSharpProgress, string jSProgress, string rubyProgress)
    {
        string html = 
            "<h1>" + updated + "</h1>" +
            "<h3>My Progress</h3>" +
            "<table>" +
            "<tr>" +
            "<td>C# </td>" +
            "<td>" + progressOptions[cSharpProgress] + "</td>" +
            "</tr>" +
            "<tr>" +
            "<td>JavaScript</td>" +
            "<td>" + progressOptions[jSProgress] + "</td>" +
            "</tr>" +
            "<tr>" +
            "<td>Ruby</td>" +
            "<td>" + progressOptions[rubyProgress] + "</td>" +
            "</tr>" +
            "</table>";

        return Content(html, "text/html");
    }
}
