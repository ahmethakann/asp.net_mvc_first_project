﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuseinessLayer.Abtract
{
    public interface ICategoryService
    {
        List<Category> GetList();
        void CategoryAdd(Category category);
    }
}
