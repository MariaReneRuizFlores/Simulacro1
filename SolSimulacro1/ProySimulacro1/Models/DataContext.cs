using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProySimulacro1.Models
{
    public class DataContext: DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<ProySimulacro1.Models.Country> Countries { get; set; }

        public System.Data.Entity.DbSet<ProySimulacro1.Models.Currency> Currencies { get; set; }

        public System.Data.Entity.DbSet<ProySimulacro1.Models.Language> Languages { get; set; }

        public System.Data.Entity.DbSet<ProySimulacro1.Models.Translations> Translations { get; set; }

        public System.Data.Entity.DbSet<ProySimulacro1.Models.RegionalBloc> RegionalBlocs { get; set; }
    }
}