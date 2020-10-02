using Reddekopp.Dev.Web.Domain;
using Reddekopp.Dev.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Reddekopp.Dev.Web.Factories
{
    public class ViewModelFactory : IViewModelFactory
    {
        public IndexViewModel CreateIndexViewModel()
        {
            var model = new IndexViewModel
            {
                Experience = new IndexViewModel.ExperienceViewModel()
            };
            model.Experience.Experiences.Add(new ExperienceItem
            {
                CompanyName = "Western Drug Distribution Center Ltd.",
                CompanyInfo = "WDDC is a veterinarian owned cooperative that services all its members needs with a single call.",
                JobTitle = "Software developer",
                StartDate = new DateTime(2017, 01, 01),
                EndDate = DateTime.Now,
                LineItems = new List<string>
                {
                    "Created an eCommerce platform that provides our clients with their own customized web store (IIS, SQL Server, .NET MVC, Stripe)",
                    "Built and maintained a production scale API that handled shipping, ordering, and receiving  (IIS, .NET Core Web Api, Swagger)",
                    "Mentored junior and intermediate developers guiding their project development",
                    "Collaborated with stakeholders by scoping and gathering requirements for our eCommerce platform",
                    "Introduced and achieved buyin for Git/GitHub as our version control system"
                },
            });

            model.Experience.Experiences.Add(new ExperienceItem
            {
                CompanyName = "West Canadian Digital Imaging",
                CompanyInfo = "Independent digital printing, graphic design, microfilming, document management, and digital imaging operations.",
                JobTitle = "Software developer",
                StartDate = new DateTime(2014, 01, 01),
                EndDate = new DateTime(2016, 12, 31),
                LineItems = new List<string>
                {
                    "Created and maintained our document capture application (C#, EMC Captiva)",
                    "Lead developer for Government of Alberta Motor Vehicles enterprise information management app",
                    "Developed data management standards, implementing best practices for data architecture, governance and processes"
                }
            });

            model.Experience.Experiences.Add(new ExperienceItem
            {
                CompanyName = "Teck",
                CompanyInfo = "Teck is Canada's largest diversified mining company and is committed to responsible development. It has major business units focused on copper, metallurgical coal, zinc, gold and energy.",
                JobTitle = "Software developer (CO-OP)",
                StartDate = new DateTime(2012, 01, 01),
                EndDate = new DateTime(2013, 01, 01),
                LineItems = new List<string>
                {
                    "Created and maintained our document capture application (C#, EMC Captiva)",
                    "Lead developer for Government of Alberta Motor Vehicles enterprise information management app",
                    "Developed data management standards, implementing best practices for data architecture, governance and processes"
                }
            });

            model.Experience.YearsOfExperience = model.Experience.Experiences.Sum(e => (e.EndDate - e.StartDate).Days) / 365;

            return model;
        }
    }
}
