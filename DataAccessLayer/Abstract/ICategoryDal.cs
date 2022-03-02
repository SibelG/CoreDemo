﻿using DataAccessLayer.Repositories;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal:IGenericDal<Category>
    {
        List<Category> ListAllCategory();
        void categoryAdd(Category category);
        void deleteCategory(Category category);
        void updateCategory(Category category);
        Category getById(int id);
    }
}
