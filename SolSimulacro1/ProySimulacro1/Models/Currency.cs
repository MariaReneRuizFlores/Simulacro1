using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProySimulacro1.Models
{
    public class Currency
    {
        [Key]
        public string code { get; set; }
        public string name { get; set; }
        public string symbol { get; set; }
    }
}