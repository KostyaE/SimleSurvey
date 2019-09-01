using SimleSurvey.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimleSurvey.Data.Interfaces
{
    public interface ISurvey
    {
        Survey CreateSurvey(int userID);

        void EditSurvey(int surveyID);
        
        void DeleteSurvey(int surveyID);

        IEnumerable<Survey> AllSurveys { get;}


        
    }
}
