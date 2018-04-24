using laiscegonha.Context;
using laiscegonha.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace laiscegonha.Repositories
{
    public class ConsultaPreNatalRepository : RepositoryBase<ConsultaPreNatal>, IConsultaPreNatalRepository
    {
        public ConsultaPreNatalRepository(LaisContext context) : base(context)
        {

        }
    }
}
