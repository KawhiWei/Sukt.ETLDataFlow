﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sukt.EntityFrameworkCore.MappingConfiguration;
using Sukt.EtlCore.Domain.Models.TaskConfig;
using System;

namespace Sukt.EtlCore.Domain.Models.EntityConfigurations.TaskConfig
{
    public class ScheduleTaskConfiguration : EntityMappingConfiguration<ScheduleTask, Guid>
    {
        public override void Map(EntityTypeBuilder<ScheduleTask> b)
        {
            b.HasKey(o => o.Id);
            b.ToTable("ETL_ScheduleTask").HasComment("任务管理");
        }
    }
}
