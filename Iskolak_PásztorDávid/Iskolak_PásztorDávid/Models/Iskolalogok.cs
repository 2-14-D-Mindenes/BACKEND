using System;
using System.Collections.Generic;

#nullable disable

namespace Iskolak_PásztorDávid.Models
{
    public partial class Iskolalogok
    {
        public int Id { get; set; }
        public int IskolaId { get; set; }
        public byte[] Logo { get; set; }

        public virtual Iskolak Iskolak { get; set; }
    }
}
