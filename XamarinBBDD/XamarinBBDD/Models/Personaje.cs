using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinBBDD.Models
{
    public class Personaje: RealmObject
    {
        public int IdPersonaje { get; set; }
        public String Nombre { get; set; }
        public String Serie { get; set; }
    }
}
