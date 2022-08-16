using System;
using Core.Persistence.Repositories;
using Domain.Entities.Concrete;

namespace Application.Services.Repositories
{
  public interface IBrandRepository : IAsyncRepository<Brand>, IRepository<Brand>
  {
  }
}

