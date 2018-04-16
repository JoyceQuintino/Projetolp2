using laiscegonha.Context;
using laiscegonha.Models;

namespace api.Controllers
{
    public class ConsultaPreNatalController : BaseController<ConsultaPreNatal>
    {
        public ConsultaPreNatalController(LaisContext context) : base(context)
        {

        }
    }
}