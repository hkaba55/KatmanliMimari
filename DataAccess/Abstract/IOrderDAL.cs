﻿using Core.DataAccess;
using DataAccess.Concrete.EntityFramework;
using Domain.Concrete.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IOrderDAL:IEntityRepository<Order>
    {

    }
}
