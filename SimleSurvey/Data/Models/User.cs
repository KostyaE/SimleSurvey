using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimleSurvey.Data.Models
{
    public class User
    {
        public int id { set; get; }

        public string firstname { set; get; }

        public string lastname { set; get; }

        public List<Survey> allsurvey { set; get; }

        //public virtual Survey Survey { set; get; }


    }
}
