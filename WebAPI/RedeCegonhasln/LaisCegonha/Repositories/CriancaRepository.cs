using laiscegonha.Context;
using laiscegonha.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace laiscegonha.Repositories
{
    public class CriancaRepository : RepositoryBase<Crianca>, ICriancaRepository
    {
        public CriancaRepository(LaisContext context) : base(context)
        {

        }
    }
}
