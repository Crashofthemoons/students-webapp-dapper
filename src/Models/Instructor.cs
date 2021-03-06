using Dapper;
using Microsoft.Data.Sqlite;
using System.ComponentModel.DataAnnotations;

namespace Workforce.Models 
{
    public class Instructor
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Slack handle")]
        [MaxLength(20)]
        public string SlackHandle { get; set; }

        [Required]
        [Display(Name = "Specialty")]
        public string Specialty { get; set; }

        [Required]
        public int CohortId { get; set; }

        [Display(Name = "Instructor Name")]
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public Cohort Cohort { get; set; }
    }
}
