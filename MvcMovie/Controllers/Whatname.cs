using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class Whatname : Controller
{
    // 
    // GET: /HelloWorld22/
    public string Index()
    {
        return "This is easyroute...";
    }
    // 
    // GET: /HelloWorld/Welcome2/ 
    public string Welcomeee()
    {
        return "This is the really easy...";
    }
}
