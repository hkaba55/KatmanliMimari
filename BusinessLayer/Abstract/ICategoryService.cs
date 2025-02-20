﻿using Domain.Concrete.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
      IDataResult<List<Category>> GetAll();
      IDataResult<Category> GetById(int categoryId);
    }

    
}
