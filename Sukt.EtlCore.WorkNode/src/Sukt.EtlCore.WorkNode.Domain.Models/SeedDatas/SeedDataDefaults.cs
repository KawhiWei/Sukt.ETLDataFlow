﻿using Microsoft.Extensions.DependencyInjection;
using Sukt.Module.Core.Entity;
using Sukt.Module.Core.Extensions;
using System;
using System.Linq;

namespace Sukt.EtlCore.WorkNode.Domain.Models.SeedDatas
{
    public abstract class SeedDataDefaults<TEntity, TKey> : SeedDataBase<TEntity, TKey>
                    where TEntity : IEntity<TKey>
          where TKey : IEquatable<TKey>
    {
        protected SeedDataDefaults(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        protected override void SaveDatabase(TEntity[] entities)
        {
            if (entities == null || entities.Length == 0)
            {
                return;
            }
            _serviceProvider.CreateScoped(provider =>
            {
                var repository = provider.GetService<IEFCoreRepository<TEntity, TKey>>();
                var unitOfWork = provider.GetService<IUnitOfWork>();
                unitOfWork.BeginTransaction();
                foreach (var entitie in entities)
                {
                    if (repository.TrackEntities.Where(Expression(entitie)).Any())
                    {
                        continue;
                    }
                    repository.Insert(entities);
                }
                unitOfWork.Commit();
            });
        }
    }
}