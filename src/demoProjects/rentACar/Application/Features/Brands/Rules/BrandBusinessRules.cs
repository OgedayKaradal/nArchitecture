using System;
using Application.Services.Repositories;
using Core.CrossCuttingConcerns.Exceptions;
using Core.Persistence.Paging;
using Domain.Entities.Concrete;

namespace Application.Features.Brands.Rules
{
  public class BrandBusinessRules
  {
    private readonly IBrandRepository _brandRepository;

    public BrandBusinessRules(IBrandRepository brandRepository)
    {
      _brandRepository = brandRepository;
    }

    public async Task BrandNameCanNotBeDuplicatedWhenInserted(string name)
    {
      IPaginate<Brand> result = await _brandRepository.GetListAsync(b => b.Name == name);
      if (result.Items.Any()) throw new BusinessException("Brand name exists.");
    }

    public void BrandMustExistWhenRequested(Brand brand)
    {
        if (brand == null) throw new BusinessException("Brand does not exist.");
    }
  }
}

