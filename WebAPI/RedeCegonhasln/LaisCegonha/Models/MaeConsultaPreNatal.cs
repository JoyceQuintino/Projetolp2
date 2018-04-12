using System;
using System.Collections.Generic;
using System.Text;

namespace laiscegonha.Models
{
    public partial class MaeConsultaPreNatal
    {
        public int Id { get; set; }
        public int IdMae { get; set; }
        public int IdConsultaPreNatal { get; set; }
        public int ConsultaPreNatalId { get; set; }

        public virtual ConsultaPreNatal ConsultaPreNatal { get; set; }
        public virtual Mae Mae { get; set; }
    }
}
