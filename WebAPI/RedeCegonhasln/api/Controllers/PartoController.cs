using laiscegonha.Context;
using laiscegonha.Models;

namespace api.Controllers
{
    public class PartoController : BaseController<Parto>
    {
        public PartoController(LaisContext context) : base(context)
        {

        }
    }
}
