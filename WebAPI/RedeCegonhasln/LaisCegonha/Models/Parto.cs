using System;
using System.Collections.Generic;
using System.Text;

namespace laiscegonha.Models
{
    public partial class Parto : IEntidade
    {
        public int Id { get; set; }
        public string LocalNasci { get; set; }
        public string Horario { get; set; }
        public int IdMae { get; set; }
        public System.DateTime DataParto { get; set; }

        public virtual Mae Mae { get; set; }
    }
}
