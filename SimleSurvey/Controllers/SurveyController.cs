using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimleSurvey.Data.Interfaces;
using SimleSurvey.ViewModesl;

namespace SimleSurvey.Controllers
{
    public class SurveyController : Controller
    {
        private readonly ISurvey _survey;

        public SurveyController(ISurvey isurvey)
        {
            _survey = isurvey;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Опросы";

            SurveyListViewModel obj = new SurveyListViewModel();
            obj.allsurvey = _survey.AllSurveys;
            obj.currSurvey = "Мои опросы";

            return View(obj);
        }

    }
}
