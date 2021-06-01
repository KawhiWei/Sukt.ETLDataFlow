﻿using Microsoft.Extensions.DependencyInjection;
using Sukt.Etlbox.Domain.Models.SystemFoundation.DataDictionary;
using SuktCore.Shared;
using SuktCore.Shared.Attributes.Dependency;
using SuktCore.Shared.Entity;
using System;

namespace Sukt.Etlbox.Domain.Repository.DomainRepository
{
    public interface IDataDictionaryRepository : IEFCoreRepository<DataDictionaryEntity, Guid>
    {
    }

    [Dependency(ServiceLifetime.Scoped)]
    public class DataDictionaryRepository : BaseRepository<DataDictionaryEntity, Guid>, IDataDictionaryRepository
    {
        public DataDictionaryRepository(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }
    }
}