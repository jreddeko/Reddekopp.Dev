using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddekopp.Dev.Web.Domain
{
    public class ExperienceItem
    {
        public string CompanyName { get; set; }
        public string CompanyInfo { get; set; }
        public string CompanyUrl { get; set; }
        public string JobTitle { get; set; }
        public List<string> LineItems { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
