using Madlibs.Models;
using Microsoft.AspNetCore.Mvc;

namespace Madlibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Madlibs() { return View(); }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/form2")]
    public ActionResult Form2() { return View(); }

    [Route("/yourmadlib")]
    public ActionResult YourMadlib(string spaceTeamName, string adverbOne, string pluralNounOne, string adverbTwo, string adjectiveOne, string pluralNounTwo, string adjectiveTwo, string verbOne, string nounFormVerb, string adjectiveThree, string pluralNounThree, string fakeDogCountry)
    {
      MadlibsVariable myMadlibsVariable = new MadlibsVariable();
      myMadlibsVariable.SpaceTeamName = spaceTeamName;
      myMadlibsVariable.AdverbOne = adverbOne;
      myMadlibsVariable.PluralNounOne = pluralNounOne;
      myMadlibsVariable.AdverbTwo = adverbTwo;
      myMadlibsVariable.AdjectiveOne = adjectiveOne;
      myMadlibsVariable.PluralNounTwo = pluralNounTwo;
      myMadlibsVariable.AdjectiveTwo = adjectiveTwo;
      myMadlibsVariable.VerbOne = verbOne;
      myMadlibsVariable.NounFormVerb = nounFormVerb;
      myMadlibsVariable.AdjectiveThree = adjectiveThree;
      myMadlibsVariable.PluralNounThree = pluralNounThree;
      myMadlibsVariable.FakeDogCountry = fakeDogCountry;
      return View(myMadlibsVariable);
    }

    [Route("/yourmadlib2")]
    public ActionResult YourMadlib2(string dayOfWeek, string name, string carModel, string weatherAdjective, string emotion, string nounOne, string nounTwo, string pastTenseVerb, string adjectiveOne, string nounThree, string verbTwo, string adverb, string adjectiveTwo, string ingVerb, string nounFour)
    {
      MadlibsVariable myMadlibsVariable = new MadlibsVariable();
      myMadlibsVariable.DayOfWeek = dayOfWeek;
      myMadlibsVariable.Name = name;
      myMadlibsVariable.CarModel = carModel;
      myMadlibsVariable.WeatherAdjective = weatherAdjective;
      myMadlibsVariable.Emotion = emotion;
      myMadlibsVariable.NounOne = nounOne;
      myMadlibsVariable.NounTwo = nounTwo;
      myMadlibsVariable.PastTenseVerb = pastTenseVerb;
      myMadlibsVariable.AdjectiveOne = adjectiveOne;
      myMadlibsVariable.NounThree = nounThree;
      myMadlibsVariable.VerbTwo = verbTwo;
      myMadlibsVariable.Adverb = adverb;
      myMadlibsVariable.AdjectiveTwo = adjectiveTwo;
      myMadlibsVariable.IngVerb = ingVerb;
      myMadlibsVariable.NounFour = nounFour;
      return View(myMadlibsVariable);
    }
  }
}