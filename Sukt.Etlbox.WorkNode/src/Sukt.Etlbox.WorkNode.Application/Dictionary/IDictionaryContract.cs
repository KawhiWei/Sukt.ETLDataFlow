﻿using Sukt.Etlbox.WorkNode.Dtos.DataDictionaryDto;
using SuktCore.Shared;
using SuktCore.Shared.Entity;
using SuktCore.Shared.Extensions.ResultExtensions;
using SuktCore.Shared.OperationResult;
using System;
using System.Threading.Tasks;

namespace Sukt.Etlbox.WorkNode.Application
{
    public interface IDictionaryContract : IScopedDependency
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<OperationResponse> InsertAsync(DataDictionaryInputDto input);

        /// <summary>
        /// 分页获取
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        Task<IPageResult<DataDictionaryOutDto>> GetResultAsync(PageRequest query);

        /// <summary>
        /// 获取树形数据
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        Task<OperationResponse> GetTreeAsync();

        /// <summary>
        /// 修改一行数据
        /// </summary>
        /// <returns></returns>
        Task<OperationResponse> UpdateAsync(DataDictionaryInputDto input);

        /// <summary>
        /// 删除一行数据
        /// </summary>
        /// <returns></returns>
        Task<OperationResponse> DeleteAsync(Guid Id);
    }
}