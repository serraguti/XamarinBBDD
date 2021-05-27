using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinBBDD.Models
{
    [Table("DEPT")]
    public class Departamento
    {
        [PrimaryKey]
        public int IdDepartamento { get; set; }
        public String Nombre { get; set; }
        public String Localidad { get; set; }
    }
}
