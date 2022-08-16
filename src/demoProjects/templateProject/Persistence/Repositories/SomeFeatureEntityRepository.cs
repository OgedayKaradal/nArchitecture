using Application2.Services.Repositories;
using Core.Persistence.Repositories;
using Domain2.Entities;
using Persistence2.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence2.Repositories
{
    public class SomeFeatureEntityRepository : EfRepositoryBase<SomeFeatureEntity, BaseDbContext>, ISomeFeatureEntityRepository
    {
        public SomeFeatureEntityRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
