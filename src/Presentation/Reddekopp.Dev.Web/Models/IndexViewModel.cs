using Reddekopp.Dev.Web.Domain;
using System;
using System.Collections.Generic;

namespace Reddekopp.Dev.Web.Models
{
    public class IndexViewModel
    {
        /// <summary>
        /// List of experience
        /// </summary>
        public ExperienceViewModel Experience { get; set; }

        /// <summary>
        /// Experience view model
        /// </summary>
        public class ExperienceViewModel
        {
            public ExperienceViewModel()
            {
                Experiences = new List<ExperienceItem>();
            }

            /// <summary>
            /// List of experience at job
            /// </summary>
            public List<ExperienceItem> Experiences { get; set; }

            /// <summary>
            /// Years of my experience
            /// </summary>
            public int YearsOfExperience { get; set; }
        }
    }
}
