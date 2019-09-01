using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using SimleSurvey.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimleSurvey.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            
            if (!content.Survey.Any())
            {
                content.AddRange(
                    new Survey { nameSurvey = "Жизнь в вашей стране!", description = "Этот опрос для того чтобы узнать на сколько вам комфортно живется в вашей стране" },
                    new Survey { nameSurvey = "Ваш уровень английского языка", description = "Этот опрос для того чтобы проверить ваш уровень знания английского языка" }
                    );
            }

            content.SaveChanges();
        }
    }
}
