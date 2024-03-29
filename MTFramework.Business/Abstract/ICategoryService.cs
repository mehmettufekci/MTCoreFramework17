﻿using MTFramework.Core.Utilities.Results;
using MTFramework.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTFramework.Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<Category> GetById(int categoryId);
        IDataResult<List<Category>> GetList();
        //IResult Add(Category category);
        //IResult Delete(Category category);
        //IResult Update(Category category);
    }
}
