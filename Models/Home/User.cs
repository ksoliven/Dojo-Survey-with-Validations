using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace DojoSurvey.Models
{
    public class Survey
    {

        [Required(ErrorMessage = "Name can not be blank.")]
        [MinLength(2, ErrorMessage = "Name must be at least 2 characters or more.")]
        public string name {get; set;}
        [Required(ErrorMessage = "Dojo can not be blank.")]
        public string dojo {get; set;}
        [Required(ErrorMessage = "Language can not be blank.")]
        public string lang {get; set;}
        [MaxLength(20, ErrorMessage = "Comments must not be more than 20 characters.")]
        public string comment {get; set;}
    }
}