﻿using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Extensions.DependencyInjection;

using JetBrains.Annotations;

namespace  Xqwyf.DependencyInjection
{
    /// <summary>
    /// DbContext的注册选项接口
    /// </summary>
    public interface IXqCommonDbContextRegistrationOptions
    {
        IServiceCollection Services { get; }

        /// <summary>
        /// 为当前的DbContext注册默认的Repositories，默认只注册聚合，如果为True，那么注册所有实体
        /// </summary>
        /// <param name="includeAllEntities">True:注册所有实体，False：注册聚合</param>
        /// <returns></returns>

        IXqCommonDbContextRegistrationOptions AddDefaultRepositoriesOption(bool includeAllEntities = false);

        /// <summary>
        /// 为当前<typeparamref name="TDefaultRepositoryDbContext"/>注册默认的Repositories，默认只注册聚合，如果为True，那么注册所有实体
        /// </summary>
        /// <typeparam name="TDefaultRepositoryDbContext">用于注册的DbContext</typeparam>
        IXqCommonDbContextRegistrationOptions AddDefaultRepositoriesOption<TDefaultRepositoryDbContext>(bool includeAllEntities = false);

        /// <summary>
        /// 为当前<paramref name="defaultRepositoryDbContextType"/>注册默认的Repositories，默认只注册聚合，如果为True，那么注册所有实体
        /// </summary>
        IXqCommonDbContextRegistrationOptions AddDefaultRepositoriesOption(Type defaultRepositoryDbContextType, bool includeAllEntities = false);

        /// <summary>
        /// 为指定的<typeparamref name="TEntity"/>注册<typeparamref name="TRepository"/>,自定义仓储将覆写默认仓储
        /// </summary>
        /// <typeparam name="TEntity">实体类型</typeparam>
        /// <typeparam name="TRepository">仓储类型</typeparam>
        IXqCommonDbContextRegistrationOptions AddRepositoryOption<TEntity, TRepository>();

        /// <summary>
        /// Uses given class(es) for default repositories.
        /// </summary>
        /// <param name="repositoryImplementationType">Repository implementation type</param>
        /// <param name="repositoryImplementationTypeWithoutKey">Repository implementation type (without primary key)</param>
        /// <returns></returns>
        IXqCommonDbContextRegistrationOptions SetDefaultRepositoryClassesOption([NotNull] Type repositoryImplementationType, [NotNull] Type repositoryImplementationTypeWithoutKey);

        /// <summary>
        /// 用给定的<typeparamref name="TOtherDbContext"/>替换当前的<see cref="DbContext"/>
        /// </summary>
        /// <typeparam name="TOtherDbContext">The DbContext type to be replaced</typeparam>
        IXqCommonDbContextRegistrationOptions ReplaceDbContextOption<TOtherDbContext>();

        /// <summary>
        /// 用给定的<typeparamref name="otherDbContextType"/>替换当前的<see cref="DbContext"/>
        /// </summary>
        /// <param name="otherDbContextType">The DbContext type to be replaced</param>
        IXqCommonDbContextRegistrationOptions ReplaceDbContextOption(Type otherDbContextType);
    }
}
