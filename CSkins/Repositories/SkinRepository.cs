using CSkins.Data;
using CSkins.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSkins.Repositories
{
    public class SkinRepository : Repository<Skin>
    {
        public SkinRepository(SkinContext context) : base(context)
        {
            
        }
    }
}
