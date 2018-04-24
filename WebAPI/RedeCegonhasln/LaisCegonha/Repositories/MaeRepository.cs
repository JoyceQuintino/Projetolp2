using laiscegonha.Context;
using laiscegonha.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace laiscegonha.Repositories
{
    public class MaeRepository : RepositoryBase<Mae>, IMaeRepository
    {
        public MaeRepository(LaisContext context) : base(context)
        {

        }
    }
}
