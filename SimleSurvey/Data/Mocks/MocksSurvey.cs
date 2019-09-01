using SimleSurvey.Data.Interfaces;
using SimleSurvey.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimleSurvey.Data.Moks
{
    public class MocksSurvey : ISurvey
    {
        public IEnumerable<Survey> AllSurveys
        {
            get
            {
                return new List<Survey>
                {
                new Survey {nameSurvey = "Жизнь в вашей стране", description = "Этот опрос для того чтобы узнать на сколько вам комфортно живется в вашей стране" },
                new Survey {nameSurvey = "Ваш уровень английского языка", description = "Этот опрос для того чтобы проверить ваш уровень знания английского языка" }
                };

            }
        }

        public Survey CreateSurvey(int userID)
        {
            return new Survey { nameSurvey = "Ваш уровень английского языка", description = "Этот опрос для того чтобы проверить ваш уровень знания английского языка" };
        }

        public void DeleteSurvey(int surveyID)
        {
            throw new NotImplementedException();
        }

        public void EditSurvey(int surveyID)
        {
            throw new NotImplementedException();
        }
    }
}
