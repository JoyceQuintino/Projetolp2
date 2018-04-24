using laiscegonha.Context;
using laiscegonha.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace laiscegonha.Repositories
{
    public class MaeConsultaRepository : RepositoryBase<MaeConsultaPreNatal>, IMaeConsultaRepository
    {
        public MaeConsultaRepository(LaisContext context) : base(context)
        {

        }
    }
}
