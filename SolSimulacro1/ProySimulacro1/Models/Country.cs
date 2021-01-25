using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProySimulacro1.Models
{
    public class Country
    {
        [Key]
        [Required]
        [StringLength(80, ErrorMessage = "Nombre debe contener de 2 a 80 caracteres", MinimumLength = 2)]
        public string name { get; set; }
        public List<string> topLevelDomain { get; set; }
        [Required]
        [StringLength(maximumLength: 2, ErrorMessage = "alpha2Code debe tener 2 caracteres", MinimumLength = 2)]
        public string alpha2Code { get; set; }
        [Required]
        [StringLength(maximumLength: 3, ErrorMessage = "alpha2Code debe tener 3 caracteres", MinimumLength = 3)]
        public string alpha3Code { get; set; }
        public List<string> callingCodes { get; set; }
        [Required]
        [StringLength(80, ErrorMessage = "Nombre debe contener de 2 a 80 caracteres", MinimumLength = 2)]
        public string capital { get; set; }
        public List<string> altSpellings { get; set; }
        public string region { get; set; }
        public string subregion { get; set; }
        [Required]
        [Range(1, 1500000000, ErrorMessage = "La poblacion debe oscilar entre 1 a 1500000000")]
        public int population { get; set; }
        public List<double> latlng { get; set; }
        [Required]
        [StringLength(80, ErrorMessage = "Nombre debe contener de 2 a 80 caracteres", MinimumLength = 2)]
        public string demonym { get; set; }
        [Required]
        [Range(1, 18000000, ErrorMessage = "El area en km2 debe oscilar entre 1 a 18000000")]
        public double area { get; set; }
        public double gini { get; set; }
        public List<string> timezones { get; set; }
        public List<string> borders { get; set; }
        [Required]
        [StringLength(80, ErrorMessage = "Nombre debe contener de 2 a 80 caracteres", MinimumLength = 2)]
        public string nativeName { get; set; }
        public string numericCode { get; set; }
        public List<Currency> currencies { get; set; }
        public List<Language> languages { get; set; }
        public Translations translations { get; set; }
        public string flag { get; set; }
        public List<RegionalBloc> regionalBlocs { get; set; }
        public string cioc { get; set; }
    }
}