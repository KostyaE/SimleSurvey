using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SimleSurvey.Data.Interfaces;
using SimleSurvey.Data.Models;

namespace SimleSurvey.Data.Repository
{
    public class SurveyRepository : ISurvey
    {
        public readonly AppDBContent appDBContent;

        public SurveyRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Survey> AllSurveys => appDBContent.Survey.Include(c => c.allQuestions);

        public Survey CreateSurvey(int userID)
        {
            throw new NotImplementedException();
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
