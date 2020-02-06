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
            //1. ispitati da li  su prosla sva pitana, ako jesu vratiti cetvrti stadijum

            //2. ispitati da li je tacno odgovoreno na tri odgovora iz druge sekcije, ako nije onda idu preporuke iz drugog stadijuma uz odgovarajucu poruku u zavisnosti od broja godina 

            //3. ispitati da li je tacno odgovorio na tri odgovora iz seste sekcije, ako nije onda idu preporuke iz treceg staijuma uz odgovarajucu poruku u avisnosti od broja godina,
            //sve posle toga je cetvrti stadijum sto se proverava na pocetku
            return View();
        }
    }
}