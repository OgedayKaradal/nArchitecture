using Core.Persistence.Repositories;
using Domain2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application2.Services.Repositories
{
    public interface ISomeFeatureEntityRepository : IAsyncRepository<SomeFeatureEntity>, IRepository<SomeFeatureEntity>
    {
    }
}
