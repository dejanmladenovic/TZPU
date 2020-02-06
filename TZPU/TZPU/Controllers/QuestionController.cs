using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TZPU.Entities;

namespace TZPU.Controllers
{
    public class QuestionController : Controller
    {
        // GET: Question
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetQuestion()
        {
            Repository.Instance._currentQuestion++;
            return View((object)Repository.Instance._questions[Repository.Instance._currentQuestion]);
        }

        [HttpGet]
        public ActionResult NumberOfYears(string years)
        {
            Repository.Instance._oldChild = Int32.Parse(years);
            if (Repository.Instance._oldChild <= 2)
            {
                return View("../Question/FirstStage");
            }
            else
            {
                Repository.Instance._currentQuestion++;
                return View("../Question/GetQuestion", (object)Repository.Instance._questions[Repository.Instance._currentQuestion]);
            }
        }

        [HttpGet]
        public ActionResult Answer(string answer)
        {
            answer = "1";
            Repository.Instance._questions[Repository.Instance._currentQuestion].CheckCorect(answer);

            if (Repository.Instance._questions.Count == Repository.Instance._currentQuestion + 1)
            {
                return View("../Question/FourthStage", (object)"Preporucujemo vam cetvrti stadijum");
            }

            if (Repository.Instance._questions[Repository.Instance._currentQuestion+1]._stage == 3 && Repository.Instance._questions[Repository.Instance._currentQuestion]._stage == 2)
            {
                if (Repository.Instance._correctAnswersSecondSection <= 3)
                    return View("../Question/SecondStage", (object)"Preporucujemo vam drugu kategoriju");
            }

            if (Repository.Instance._questions[Repository.Instance._currentQuestion+1]._stage == 7 && Repository.Instance._questions[Repository.Instance._currentQuestion]._stage == 6)
            {
                if (Repository.Instance._correctAnswersSixthSection <= 3)
                    return View("../Question/ThirdStage", (object)"Preporucujemo vam trecu kategoriju");
            }


            Repository.Instance._currentQuestion++;
            return View("../Question/GetQuestion", (object)Repository.Instance._questions[Repository.Instance._currentQuestion]);
        }
    }
}