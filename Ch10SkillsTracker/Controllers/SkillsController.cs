using Microsoft.AspNetCore.Mvc;

namespace Ch10SkillsTracker;

[Route("/skills")]
public class SkillsController : Controller
{
    // Endpoint: GET /skills
    [HttpGet] // defaults to base route for controller
    public IActionResult RenderSkillsPage()
    {
        string html = 
            "<h1>Skills Tracker</h1>" +
            "<h2>We have a few skills we would like to learn. Here is the list!</h2>" +
            "<ol>" +
            "<li>C#</li>" +
            "<li>Java</li>" +
            "<li>JavaScript</li>" +
            "<li>TypeScript</li>" +
            "<li>Ruby</li>" +
            "</ol>" +
            "<p>Click <a href='/skills/form'>here</a> to select your favorite.</p>";

        return Content(html, "text/html");
    }

    // Endpoint: GET /skills/form
    [HttpGet("form")]
    public IActionResult RenderSkillsForm()
    {
        string options = 
            "<option value='CSharp'>C#</option>" +
            "<option value='Java'>Java</option>" +
            "<option value='JavaScript'>JavaScript</option>" +
            "<option value='TypeScript'>TypeScript</option>" +
            "<option value='Ruby'>Ruby</option>";

        string html = 
            // BONUS MISSION 2 - Post to /results instead of /form
            "<form action='/skills/results' method='POST'>" +
            "<label>Name:</label>" +
            "<input type='text' name='userName' /><br />" +
            "<label>My favorite language:</label>" +
            "<select name='fave1'>" +
            options +
            "</select><br />" +
            "<label>My second favorite language:</label>" +
            "<select name='fave2'>" +
            options +
            "</select><br />" +
            "<label>My third favorite language:</label>" +
            "<select name='fave3'>" +
            options +
            "</select><br />" +
            "<button type='submit'>Submit</button>" +
            "</form>";

        return Content(html, "text/html");
    }

    // Endpoint: POST /skills/form
    // This is no longer used after bonus mission
    [HttpPost("form")]
    public IActionResult ProcessSkillsForm(string username, string fave1, string fave2, string fave3)
    {
        string html = 
            "<h1>" + username + "</h1>" +
            "<h3>Favorite Languages</h3>" +
            "<ol>" +
            "<li>" + fave1 + "</li>" +
            "<li>" + fave2 + "</li>" +
            "<li>" + fave3 + "</li>" +
            "</ol>";

        return Content(html, "text/html");
    }

    // Endpoint: POST /skills/results
    // BONUS MISSION 1 - Use table instead of ordered list
    // BONUS MISSION 2 - Route to /results instead of /form
    [HttpPost("results")]
    public IActionResult ProcessSkillsFormBonus(string username, string fave1, string fave2, string fave3)
    {
        string html = 
            "<h1>" + username + "</h1>" +
            "<h3>Favorite Languages</h3>" +
            "<table>" +
            "<tr>" +
            "<td>1.</td>" +
            "<td>" + fave1 + "</td>" +
            "</tr>" +
            "<tr>" +
            "<td>2.</td>" +
            "<td>" + fave2 + "</td>" +
            "</tr>" +
            "<tr>" +
            "<td>3.</td>" +
            "<td>" + fave3 + "</td>" +
            "</tr>" +
            "</table>";

        return Content(html, "text/html");
    }
}
