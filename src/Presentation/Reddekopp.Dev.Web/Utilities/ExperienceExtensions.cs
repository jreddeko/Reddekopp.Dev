using Reddekopp.Dev.Web.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddekopp.Dev.Web
{
    public static class ExperienceExtensions
    {
        public static string GetTimeAtJobString(this ExperienceItem experience)
            => $"{experience.StartDate:MMMM yyyy} to {experience.EndDate:MMMM yyyy}";
    }
}
