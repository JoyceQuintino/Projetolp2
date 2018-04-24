using laiscegonha.Context;
using laiscegonha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Controllers
{
    public class MaeConsultaController : BaseController<MaeConsultaPreNatal>
    {
        public MaeConsultaController(LaisContext context) : base(context)
        {

        }
    }

}
