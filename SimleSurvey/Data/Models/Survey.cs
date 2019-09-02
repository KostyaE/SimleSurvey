using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimleSurvey.Data.Models
{
    public class Survey
    {
        public readonly AppDBContent appDBContent;

        public Survey(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public int id { set; get; }

        public string nameSurvey { set; get; }

        public string description { set; get; }

        public List<Question> allQuestions { get; set; }

        public bool active { set; get; } //открыт или закрыт опрос


        public void AddQuastion()
        {
            this.appDBContent.Question.Add(new Question
            {
                question = "Vopros1",
                answer = "Otvet1"
            });

            appDBContent.SaveChanges();
        }

        public List<Question> GetQuas()
        {
            return appDBContent.Question.Where(c => c.id == id).ToList();
        }

    }
}
