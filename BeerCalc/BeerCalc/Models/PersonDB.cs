using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BeerCalc.Models
{
    public class PersonDB
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Chociaż się przedstaw :)")]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Podaj wiek")]
        public int Age { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Podaj swoją masę")]
        public int Weight { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Podaj swój wzrost")]
        public int Height { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Musisz podać jak bardzo jesteś wprawiony/wprawiona")]
        public int Expierience { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Podaj adres email - tam dostaniesz wynik")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Podaj prawidłowy adres email")]
        public string Email { get; set; }

    }
}