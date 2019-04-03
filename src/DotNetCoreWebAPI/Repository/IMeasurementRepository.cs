﻿using DotNetCoreWebApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreWebAPI.Repository
{
    public interface IMeasurementRepository<TEntity>
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> Get(long id);
        Task Add(TEntity entity);
        Task Update(Measurement measurement, TEntity entity);
        Task Delete(Measurement measurement);
    }
}
