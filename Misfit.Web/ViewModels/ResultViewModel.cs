using System;
using System.ComponentModel.DataAnnotations;

namespace Misfit.Web.ViewModels
{
    public class ResultViewModel
    {
        public int Id { get; set; }
        [Required]
        public string FirstNumber { get; set; }
        [Required]
        public string SecondNumber { get; set; }
        public string Sum { get; set; }
        public DateTime DateOfCalculation { get; set; }
        public UserViewModel User { get; set; }
    }
}
