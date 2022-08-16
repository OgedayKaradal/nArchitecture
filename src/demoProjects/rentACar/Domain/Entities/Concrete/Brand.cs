using System;
using Core.Persistence.Repositories;

namespace Domain.Entities.Concrete
{
  public class Brand:Entity
  {
    public string Name { get; set; }

    public Brand()
    {
    }

    public Brand(int id,string name):this()
    {
      Name = name;
      Id = id;
    }
  }
}

