using laiscegonha.Context;
using laiscegonha.Models;

namespace api.Controllers
{
    public class CriancaController : BaseController<Crianca>
    {
        public CriancaController(LaisContext context) : base(context)
        {

        }
    }
}