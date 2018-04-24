using laiscegonha.Context;
using laiscegonha.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace laiscegonha.Repositories
{
    public class PartoRepository : RepositoryBase<Parto>, IPartoRepository
    {
        public PartoRepository(LaisContext context) : base(context)
        {

        }
    }
}
