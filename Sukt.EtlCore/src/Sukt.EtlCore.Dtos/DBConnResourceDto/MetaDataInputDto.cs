﻿using Sukt.EtlCore.Domain.Models.DBConnResource;
using Sukt.Module.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Sukt.EtlCore.Dtos.DataDictionaryDto
{
    /// <summary>
    /// 元数据输入Dto
    /// </summary>
    public class MetaDataInputDto
    {
        [DisplayName("元数据类型")]
        public MetaDataTypeEnum MetaDataType { get; set; }
        [DisplayName("元数据名称")]
        public string Name { get; set; }
        [DisplayName("备注")]
        public string Describe { get; set; }
    }
    /// <summary>
    /// 元数据输入Dto
    /// </summary>
    public class MetaDataImportInputDto : InputDto<Guid>
    {
        public List<MetaDataInputDto> MetaDatas { get; set; }
    }
}
