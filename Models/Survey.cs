using System;
using System.ComponentModel.DataAnnotations;

namespace DojoSurveyValidation.Models
{
    public class Survey
    {
        [MinLength (2, ErrorMessage = "Name needs to be more than 2 characters")]
        [Required (ErrorMessage = "Name cannot be blank!")]
        [Display (Name="Name: ")]
        public string nameField{get;set;}

        [Required (ErrorMessage = "Choose a Dojo Location")]
        [Display (Name="Dojo Location: ")]
        public string locaField{get;set;}

        [Required (ErrorMessage = "Choose a Favorite Language")]
        [Display (Name="Favorite Language: ")]
        public string langField{get;set;}

        [MaxLength (20, ErrorMessage = "Comment should be at most 20 characters")]
        [Display (Name="Comment (optional): ")]
        public string commField{get;set;}
    }
}