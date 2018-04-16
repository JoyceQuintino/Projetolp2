using laiscegonha.Context;
using laiscegonha.Models;

namespace api.Controllers
{
    public class MaeController : BaseController<Mae>
    {
        public MaeController(LaisContext context) : base(context)
        {

        }
    }
}
