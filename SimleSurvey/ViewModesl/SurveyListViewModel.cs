using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimleSurvey.Data.Models;

namespace SimleSurvey.ViewModesl
{
    public class SurveyListViewModel
    {
        public IEnumerable<Survey> allsurvey { get; set; }

        public string currSurvey { get; set; }
    }
}
