using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProySimulacro1.Models
{
    public class RegionalBloc
    {
        [Key]
        public string acronym { get; set; }
        public string name { get; set; }
        public List<string> otherAcronyms { get; set; }
        public List<string> otherNames { get; set; }
    }
}