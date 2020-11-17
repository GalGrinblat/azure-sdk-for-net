// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RedisEnterprise
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for RedisEnterpriseDatabaseOperations.
    /// </summary>
    public static partial class RedisEnterpriseDatabaseOperationsExtensions
    {
            /// <summary>
            /// Retrieves the access keys for the RedisEnterprise database.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the RedisEnterprise cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            public static AccessKeys ListKeys(this IRedisEnterpriseDatabaseOperations operations, string resourceGroupName, string clusterName, string databaseName)
            {
                return operations.ListKeysAsync(resourceGroupName, clusterName, databaseName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves the access keys for the RedisEnterprise database.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the RedisEnterprise cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AccessKeys> ListKeysAsync(this IRedisEnterpriseDatabaseOperations operations, string resourceGroupName, string clusterName, string databaseName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListKeysWithHttpMessagesAsync(resourceGroupName, clusterName, databaseName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Regenerates the RedisEnterprise database's access keys.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the RedisEnterprise cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='keyType'>
            /// Which access key to regenerate. Possible values include: 'Primary',
            /// 'Secondary'
            /// </param>
            public static AccessKeys RegenerateKey(this IRedisEnterpriseDatabaseOperations operations, string resourceGroupName, string clusterName, string databaseName, AccessKeyType keyType)
            {
                return operations.RegenerateKeyAsync(resourceGroupName, clusterName, databaseName, keyType).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Regenerates the RedisEnterprise database's access keys.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the RedisEnterprise cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='keyType'>
            /// Which access key to regenerate. Possible values include: 'Primary',
            /// 'Secondary'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AccessKeys> RegenerateKeyAsync(this IRedisEnterpriseDatabaseOperations operations, string resourceGroupName, string clusterName, string databaseName, AccessKeyType keyType, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RegenerateKeyWithHttpMessagesAsync(resourceGroupName, clusterName, databaseName, keyType, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Imports a database file to target database.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the RedisEnterprise cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='sasUri'>
            /// SAS Uri for the target blob to import from
            /// </param>
            public static void Import(this IRedisEnterpriseDatabaseOperations operations, string resourceGroupName, string clusterName, string databaseName, string sasUri)
            {
                operations.ImportAsync(resourceGroupName, clusterName, databaseName, sasUri).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Imports a database file to target database.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the RedisEnterprise cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='sasUri'>
            /// SAS Uri for the target blob to import from
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ImportAsync(this IRedisEnterpriseDatabaseOperations operations, string resourceGroupName, string clusterName, string databaseName, string sasUri, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ImportWithHttpMessagesAsync(resourceGroupName, clusterName, databaseName, sasUri, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Exports a database file from target database.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the RedisEnterprise cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='sasUri'>
            /// SAS Uri for the target directory to export to
            /// </param>
            public static void Export(this IRedisEnterpriseDatabaseOperations operations, string resourceGroupName, string clusterName, string databaseName, string sasUri)
            {
                operations.ExportAsync(resourceGroupName, clusterName, databaseName, sasUri).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Exports a database file from target database.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the RedisEnterprise cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='sasUri'>
            /// SAS Uri for the target directory to export to
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ExportAsync(this IRedisEnterpriseDatabaseOperations operations, string resourceGroupName, string clusterName, string databaseName, string sasUri, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ExportWithHttpMessagesAsync(resourceGroupName, clusterName, databaseName, sasUri, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Regenerates the RedisEnterprise database's access keys.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the RedisEnterprise cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='keyType'>
            /// Which access key to regenerate. Possible values include: 'Primary',
            /// 'Secondary'
            /// </param>
            public static AccessKeys BeginRegenerateKey(this IRedisEnterpriseDatabaseOperations operations, string resourceGroupName, string clusterName, string databaseName, AccessKeyType keyType)
            {
                return operations.BeginRegenerateKeyAsync(resourceGroupName, clusterName, databaseName, keyType).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Regenerates the RedisEnterprise database's access keys.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the RedisEnterprise cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='keyType'>
            /// Which access key to regenerate. Possible values include: 'Primary',
            /// 'Secondary'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AccessKeys> BeginRegenerateKeyAsync(this IRedisEnterpriseDatabaseOperations operations, string resourceGroupName, string clusterName, string databaseName, AccessKeyType keyType, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginRegenerateKeyWithHttpMessagesAsync(resourceGroupName, clusterName, databaseName, keyType, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Imports a database file to target database.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the RedisEnterprise cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='sasUri'>
            /// SAS Uri for the target blob to import from
            /// </param>
            public static void BeginImport(this IRedisEnterpriseDatabaseOperations operations, string resourceGroupName, string clusterName, string databaseName, string sasUri)
            {
                operations.BeginImportAsync(resourceGroupName, clusterName, databaseName, sasUri).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Imports a database file to target database.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the RedisEnterprise cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='sasUri'>
            /// SAS Uri for the target blob to import from
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginImportAsync(this IRedisEnterpriseDatabaseOperations operations, string resourceGroupName, string clusterName, string databaseName, string sasUri, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginImportWithHttpMessagesAsync(resourceGroupName, clusterName, databaseName, sasUri, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Exports a database file from target database.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the RedisEnterprise cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='sasUri'>
            /// SAS Uri for the target directory to export to
            /// </param>
            public static void BeginExport(this IRedisEnterpriseDatabaseOperations operations, string resourceGroupName, string clusterName, string databaseName, string sasUri)
            {
                operations.BeginExportAsync(resourceGroupName, clusterName, databaseName, sasUri).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Exports a database file from target database.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the RedisEnterprise cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database.
            /// </param>
            /// <param name='sasUri'>
            /// SAS Uri for the target directory to export to
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginExportAsync(this IRedisEnterpriseDatabaseOperations operations, string resourceGroupName, string clusterName, string databaseName, string sasUri, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginExportWithHttpMessagesAsync(resourceGroupName, clusterName, databaseName, sasUri, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}