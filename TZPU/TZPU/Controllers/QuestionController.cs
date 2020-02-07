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
            //Session["currentQuestion"] = (int)Session["currentQuestion"] + 1;
            if(Session["currentQuestion"] == null)
            {
                Session["currentQuestion"] = 1;
            }
            return View((object)Repository.Instance._questions[(int)Session["currentQuestion"]]);
        }

        [HttpGet]
        public ActionResult NumberOfYears(string years)
        {
            Session["oldChild"] = Int32.Parse(years);
            Session["currentQuestion"] = -1;
            Session["correctAnswersSecondSection"] = 0;
            Session["correctAnswersSixthSection"] = 0;

            if ((int)Session["oldChild"] <= 2)
            {
                return View("../Question/FirstStage");
            }
            else
            {
                Session["currentQuestion"] = (int)Session["currentQuestion"] + 1;
                return View("../Question/GetQuestion", (object)Repository.Instance._questions[(int)Session["currentQuestion"]]);
            }
        }

        [HttpGet]
        public ActionResult Answer(string answer)
        {
            if (Repository.Instance._questions[(int)Session["currentQuestion"]].CheckCorect(answer))
            {
                if (Repository.Instance._questions[(int)Session["currentQuestion"]]._stage == 2)
                {
                    Session["correctAnswersSecondSection"] = (int)Session["correctAnswersSecondSection"] + 1;
                }
                else if (Repository.Instance._questions[(int)Session["currentQuestion"]]._stage == 6)
                {
                    Session["correctAnswersSixthSection"] = (int)Session["correctAnswersSixthSection"] + 1;
                }
            }

            if (Repository.Instance._questions.Count == (int)Session["currentQuestion"] + 1)
            {
                return View("../Question/FourthStage", (object)"Preporucujemo vam cetvrti stadijum");
            }

            if (Repository.Instance._questions[(int)Session["currentQuestion"] + 1]._stage == 3 && Repository.Instance._questions[(int)Session["currentQuestion"]]._stage == 2)
            {
                if ((int)Session["correctAnswersSecondSection"] <= 3)
                    return View("../Question/SecondStage", (object)"Preporucujemo vam drugu kategoriju");
            }

            if (Repository.Instance._questions[(int)Session["currentQuestion"] + 1]._stage == 7 && Repository.Instance._questions[(int)Session["currentQuestion"]]._stage == 6)
            {
                if ((int)Session["correctAnswersSixthSection"] <= 3)
                    return View("../Question/ThirdStage", (object)"Preporucujemo vam trecu kategoriju");
            }


            Session["currentQuestion"] = (int)Session["currentQuestion"] + 1;
            return View("../Question/GetQuestion", (object)Repository.Instance._questions[(int)Session["currentQuestion"]]);
        }
    }
}