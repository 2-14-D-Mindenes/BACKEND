using System;
using System.Collections.Generic;

#nullable disable

namespace Iskolak_PásztorDávid.Models
{
    public partial class Diakok
    {
        public int Id { get; set; }
        public string Tanev { get; set; }
        public int IskolaId { get; set; }
        public string OktatasiAzonosito { get; set; }
        public string Nev { get; set; }
        public string Osztaly { get; set; }

        public virtual Iskolak Iskola { get; set; }
    }
}
