﻿using QuizAplicationRtk.Domain.Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAplicationRtk.Domain.Interfaces.Repositories;


public interface IBaseRepository<TEntity> : IStateSaveChanges
{
    IQueryable<TEntity> GetAll();

    Task<TEntity> CreateAsync(TEntity entity);

    TEntity Update(TEntity entity);

    void Remove(TEntity entity);
}