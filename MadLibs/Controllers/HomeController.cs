using Microsoft.AspNetCore.Mvc;
using MidLabs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form() { return View(); }

    [Route("/story")]
    public ActionResult Story(string holiday, string name1, string name2, string verb1, string verb2, string verb3, string noun1, string noun2,
    string noun3, string adjective1, string adjective2, string adjective3, string store1, string store2)
    {
      StoryVariable newStoryVariable = new StoryVariable();

      newStoryVariable.Holiday = holiday;

      newStoryVariable.Name1 = name1;
      newStoryVariable.Name2 = name2;

      newStoryVariable.Verb1 = verb1;
      newStoryVariable.Verb2 = verb2;
      newStoryVariable.Verb3 = verb3;

      newStoryVariable.Adjective1 = adjective1;
      newStoryVariable.Adjective2 = adjective2;
      newStoryVariable.Adjective3 = adjective3;

      newStoryVariable.Noun1 = noun1;
      newStoryVariable.Noun2 = noun2;
      newStoryVariable.Noun3 = noun3;

      newStoryVariable.Store1 = store1;
      newStoryVariable.Store2 = store2;

      return View(newStoryVariable);
    }

  }
}