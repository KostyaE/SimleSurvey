using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimleSurvey.Data.Models
{
    public class Survey
    {
        public int id { set; get; }

        public string nameSurvey { set; get; }

        public string description { set; get; }

        public List<Question> allQuestions { get; set; }

        public bool active { set; get; } //открыт или закрыт опрос


    }
}
