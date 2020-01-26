﻿using Medallion.Threading.Tests.Sql;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medallion.Threading.Tests
{
    // Contains test classes which implement abstract test cases in all valid combinations. Tests missing from here are discovered by TestSetupTest
    public class Core_SystemEngineTest : DistributedLockCoreTestCases<TestingSystemDistributedLockEngine> { }
    public class Core_SqlEngine_NoStrategyConnectionStringProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedLockEngine<NoStrategyConnectionStringProvider>> { }
    public class Core_SqlEngine_DefaultConnectionStringProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedLockEngine<DefaultConnectionStringProvider>> { }
    public class Core_SqlEngine_AzureConnectionStringProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedLockEngine<AzureConnectionStringProvider>> { }
    public class Core_SqlEngine_ConnectionBasedConnectionStringProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedLockEngine<ConnectionBasedConnectionStringProvider>> { }
    public class Core_SqlEngine_TransactionBasedConnectionStringProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedLockEngine<TransactionBasedConnectionStringProvider>> { }
    public class Core_SqlEngine_MultiplexedConnectionStringProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedLockEngine<MultiplexedConnectionStringProvider>> { }
    public class Core_SqlEngine_ConnectionProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedLockEngine<ConnectionProvider>> { }
    public class Core_SqlEngine_TransactionProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedLockEngine<TransactionProvider>> { }
    public class Core_SqlReaderWriterEngine_NoStrategyConnectionStringProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedReaderWriterLockEngine<NoStrategyConnectionStringProvider>> { }
    public class Core_SqlReaderWriterEngine_DefaultConnectionStringProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedReaderWriterLockEngine<DefaultConnectionStringProvider>> { }
    public class Core_SqlReaderWriterEngine_AzureConnectionStringProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedReaderWriterLockEngine<AzureConnectionStringProvider>> { }
    public class Core_SqlReaderWriterEngine_ConnectionBasedConnectionStringProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedReaderWriterLockEngine<ConnectionBasedConnectionStringProvider>> { }
    public class Core_SqlReaderWriterEngine_TransactionBasedConnectionStringProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedReaderWriterLockEngine<TransactionBasedConnectionStringProvider>> { }
    public class Core_SqlReaderWriterEngine_MultiplexedConnectionStringProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedReaderWriterLockEngine<MultiplexedConnectionStringProvider>> { }
    public class Core_SqlReaderWriterEngine_ConnectionProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedReaderWriterLockEngine<ConnectionProvider>> { }
    public class Core_SqlReaderWriterEngine_TransactionProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedReaderWriterLockEngine<TransactionProvider>> { }
    public class AzureConnectionStrategy_SqlEngineFactoryTest : AzureConnectionStrategyTestCases<TestingSqlDistributedLockEngineFactory> { }
    public class AzureConnectionStrategy_SqlReaderWriterEngineFactoryTest : AzureConnectionStrategyTestCases<TestingSqlDistributedReaderWriterLockEngineFactory> { }
    public class AzureConnectionStrategy_SqlSemaphoreEngineFactoryTest : AzureConnectionStrategyTestCases<TestingSqlDistributedSemaphoreEngineFactory> { }
    public class SqlReaderWriter_NoStrategyConnectionStringProviderTest : SqlDistributedReaderWriterLockTestCases<NoStrategyConnectionStringProvider> { }
    public class SqlReaderWriter_DefaultConnectionStringProviderTest : SqlDistributedReaderWriterLockTestCases<DefaultConnectionStringProvider> { }
    public class SqlReaderWriter_AzureConnectionStringProviderTest : SqlDistributedReaderWriterLockTestCases<AzureConnectionStringProvider> { }
    public class SqlReaderWriter_ConnectionBasedConnectionStringProviderTest : SqlDistributedReaderWriterLockTestCases<ConnectionBasedConnectionStringProvider> { }
    public class SqlReaderWriter_TransactionBasedConnectionStringProviderTest : SqlDistributedReaderWriterLockTestCases<TransactionBasedConnectionStringProvider> { }
    public class SqlReaderWriter_MultiplexedConnectionStringProviderTest : SqlDistributedReaderWriterLockTestCases<MultiplexedConnectionStringProvider> { }
    public class SqlReaderWriter_ConnectionProviderTest : SqlDistributedReaderWriterLockTestCases<ConnectionProvider> { }
    public class SqlReaderWriter_TransactionProviderTest : SqlDistributedReaderWriterLockTestCases<TransactionProvider> { }
    public class Core_SqlSemaphoreEngine_NoStrategyConnectionStringProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedSemaphoreEngine<NoStrategyConnectionStringProvider>> { }
    public class Core_SqlSemaphoreEngine_DefaultConnectionStringProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedSemaphoreEngine<DefaultConnectionStringProvider>> { }
    public class Core_SqlSemaphoreEngine_AzureConnectionStringProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedSemaphoreEngine<AzureConnectionStringProvider>> { }
    public class Core_SqlSemaphoreEngine_ConnectionBasedConnectionStringProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedSemaphoreEngine<ConnectionBasedConnectionStringProvider>> { }
    public class Core_SqlSemaphoreEngine_TransactionBasedConnectionStringProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedSemaphoreEngine<TransactionBasedConnectionStringProvider>> { }
    public class Core_SqlSemaphoreEngine_MultiplexedConnectionStringProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedSemaphoreEngine<MultiplexedConnectionStringProvider>> { }
    public class Core_SqlSemaphoreEngine_ConnectionProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedSemaphoreEngine<ConnectionProvider>> { }
    public class Core_SqlSemaphoreEngine_TransactionProviderTest : DistributedLockCoreTestCases<TestingSqlDistributedSemaphoreEngine<TransactionProvider>> { }
    public class Core_MostlyDrainedSqlSemaphoreEngineTest : DistributedLockCoreTestCases<TestingMostlyDrainedSqlSemaphoreDistributedLockEngine> { }
    public class SqlSemaphore_NoStrategyConnectionStringProviderTest : SqlDistributedSemaphoreTestCases<NoStrategyConnectionStringProvider> { }
    public class SqlSemaphore_DefaultConnectionStringProviderTest : SqlDistributedSemaphoreTestCases<DefaultConnectionStringProvider> { }
    public class SqlSemaphore_AzureConnectionStringProviderTest : SqlDistributedSemaphoreTestCases<AzureConnectionStringProvider> { }
    public class SqlSemaphore_ConnectionBasedConnectionStringProviderTest : SqlDistributedSemaphoreTestCases<ConnectionBasedConnectionStringProvider> { }
    public class SqlSemaphore_TransactionBasedConnectionStringProviderTest : SqlDistributedSemaphoreTestCases<TransactionBasedConnectionStringProvider> { }
    public class SqlSemaphore_MultiplexedConnectionStringProviderTest : SqlDistributedSemaphoreTestCases<MultiplexedConnectionStringProvider> { }
    public class SqlSemaphore_ConnectionProviderTest : SqlDistributedSemaphoreTestCases<ConnectionProvider> { }
    public class SqlSemaphore_TransactionProviderTest : SqlDistributedSemaphoreTestCases<TransactionProvider> { }
    public class ExternalConnectionStrategy_SqlEngineFactoryTest : ExternalConnectionStrategyTestCases<TestingSqlDistributedLockEngineFactory> { }
    public class ExternalConnectionStrategy_SqlReaderWriterEngineFactoryTest : ExternalConnectionStrategyTestCases<TestingSqlDistributedReaderWriterLockEngineFactory> { }
    public class ExternalConnectionStrategy_SqlSemaphoreEngineFactoryTest : ExternalConnectionStrategyTestCases<TestingSqlDistributedSemaphoreEngineFactory> { }
    public class ExternalTransactionStrategy_SqlEngineFactoryTest : ExternalTransactionStrategyTestCases<TestingSqlDistributedLockEngineFactory> { }
    public class ExternalTransactionStrategy_SqlReaderWriterEngineFactoryTest : ExternalTransactionStrategyTestCases<TestingSqlDistributedReaderWriterLockEngineFactory> { }
    public class ExternalTransactionStrategy_SqlSemaphoreEngineFactoryTest : ExternalTransactionStrategyTestCases<TestingSqlDistributedSemaphoreEngineFactory> { }
    public class OwnedTransactionStrategy_SqlEngineFactoryTest : OwnedTransactionStrategyTestCases<TestingSqlDistributedLockEngineFactory> { }
    public class OwnedTransactionStrategy_SqlReaderWriterEngineFactoryTest : OwnedTransactionStrategyTestCases<TestingSqlDistributedReaderWriterLockEngineFactory> { }
    public class OwnedTransactionStrategy_SqlSemaphoreEngineFactoryTest : OwnedTransactionStrategyTestCases<TestingSqlDistributedSemaphoreEngineFactory> { }
    public class MultiplexingConnectionStrategy_SqlEngineFactoryTest : MultiplexingConnectionStrategyTestCases<TestingSqlDistributedLockEngineFactory> { }
    public class MultiplexingConnectionStrategy_SqlReaderWriterEngineFactoryTest : MultiplexingConnectionStrategyTestCases<TestingSqlDistributedReaderWriterLockEngineFactory> { }
    public class MultiplexingConnectionStrategy_SqlSemaphoreEngineFactoryTest : MultiplexingConnectionStrategyTestCases<TestingSqlDistributedSemaphoreEngineFactory> { }
    public class SqlSemaphoreSelfDeadlock_ConnectionProviderTest : SqlDistributedSemaphoreSelfDeadlockTestCases<ConnectionProvider> { }
    public class SqlSemaphoreSelfDeadlock_TransactionProviderTest : SqlDistributedSemaphoreSelfDeadlockTestCases<TransactionProvider> { }
    public class ConnectionStringStrategy_SqlEngineFactory_NoStrategyConnectionStringProviderTest : ConnectionStringStrategyTestCases<TestingSqlDistributedLockEngineFactory, NoStrategyConnectionStringProvider> { }
    public class ConnectionStringStrategy_SqlEngineFactory_DefaultConnectionStringProviderTest : ConnectionStringStrategyTestCases<TestingSqlDistributedLockEngineFactory, DefaultConnectionStringProvider> { }
    public class ConnectionStringStrategy_SqlEngineFactory_AzureConnectionStringProviderTest : ConnectionStringStrategyTestCases<TestingSqlDistributedLockEngineFactory, AzureConnectionStringProvider> { }
    public class ConnectionStringStrategy_SqlEngineFactory_ConnectionBasedConnectionStringProviderTest : ConnectionStringStrategyTestCases<TestingSqlDistributedLockEngineFactory, ConnectionBasedConnectionStringProvider> { }
    public class ConnectionStringStrategy_SqlEngineFactory_TransactionBasedConnectionStringProviderTest : ConnectionStringStrategyTestCases<TestingSqlDistributedLockEngineFactory, TransactionBasedConnectionStringProvider> { }
    public class ConnectionStringStrategy_SqlEngineFactory_MultiplexedConnectionStringProviderTest : ConnectionStringStrategyTestCases<TestingSqlDistributedLockEngineFactory, MultiplexedConnectionStringProvider> { }
    public class ConnectionStringStrategy_SqlReaderWriterEngineFactory_NoStrategyConnectionStringProviderTest : ConnectionStringStrategyTestCases<TestingSqlDistributedReaderWriterLockEngineFactory, NoStrategyConnectionStringProvider> { }
    public class ConnectionStringStrategy_SqlReaderWriterEngineFactory_DefaultConnectionStringProviderTest : ConnectionStringStrategyTestCases<TestingSqlDistributedReaderWriterLockEngineFactory, DefaultConnectionStringProvider> { }
    public class ConnectionStringStrategy_SqlReaderWriterEngineFactory_AzureConnectionStringProviderTest : ConnectionStringStrategyTestCases<TestingSqlDistributedReaderWriterLockEngineFactory, AzureConnectionStringProvider> { }
    public class ConnectionStringStrategy_SqlReaderWriterEngineFactory_ConnectionBasedConnectionStringProviderTest : ConnectionStringStrategyTestCases<TestingSqlDistributedReaderWriterLockEngineFactory, ConnectionBasedConnectionStringProvider> { }
    public class ConnectionStringStrategy_SqlReaderWriterEngineFactory_TransactionBasedConnectionStringProviderTest : ConnectionStringStrategyTestCases<TestingSqlDistributedReaderWriterLockEngineFactory, TransactionBasedConnectionStringProvider> { }
    public class ConnectionStringStrategy_SqlReaderWriterEngineFactory_MultiplexedConnectionStringProviderTest : ConnectionStringStrategyTestCases<TestingSqlDistributedReaderWriterLockEngineFactory, MultiplexedConnectionStringProvider> { }
    public class ConnectionStringStrategy_SqlSemaphoreEngineFactory_NoStrategyConnectionStringProviderTest : ConnectionStringStrategyTestCases<TestingSqlDistributedSemaphoreEngineFactory, NoStrategyConnectionStringProvider> { }
    public class ConnectionStringStrategy_SqlSemaphoreEngineFactory_DefaultConnectionStringProviderTest : ConnectionStringStrategyTestCases<TestingSqlDistributedSemaphoreEngineFactory, DefaultConnectionStringProvider> { }
    public class ConnectionStringStrategy_SqlSemaphoreEngineFactory_AzureConnectionStringProviderTest : ConnectionStringStrategyTestCases<TestingSqlDistributedSemaphoreEngineFactory, AzureConnectionStringProvider> { }
    public class ConnectionStringStrategy_SqlSemaphoreEngineFactory_ConnectionBasedConnectionStringProviderTest : ConnectionStringStrategyTestCases<TestingSqlDistributedSemaphoreEngineFactory, ConnectionBasedConnectionStringProvider> { }
    public class ConnectionStringStrategy_SqlSemaphoreEngineFactory_TransactionBasedConnectionStringProviderTest : ConnectionStringStrategyTestCases<TestingSqlDistributedSemaphoreEngineFactory, TransactionBasedConnectionStringProvider> { }
    public class ConnectionStringStrategy_SqlSemaphoreEngineFactory_MultiplexedConnectionStringProviderTest : ConnectionStringStrategyTestCases<TestingSqlDistributedSemaphoreEngineFactory, MultiplexedConnectionStringProvider> { }
    public class ExternalConnectionOrTransactionStrategy_SqlEngineFactory_ConnectionProviderTest : ExternalConnectionOrTransactionStrategyTestCases<TestingSqlDistributedLockEngineFactory, ConnectionProvider> { }
    public class ExternalConnectionOrTransactionStrategy_SqlEngineFactory_TransactionProviderTest : ExternalConnectionOrTransactionStrategyTestCases<TestingSqlDistributedLockEngineFactory, TransactionProvider> { }
    public class ExternalConnectionOrTransactionStrategy_SqlReaderWriterEngineFactory_ConnectionProviderTest : ExternalConnectionOrTransactionStrategyTestCases<TestingSqlDistributedReaderWriterLockEngineFactory, ConnectionProvider> { }
    public class ExternalConnectionOrTransactionStrategy_SqlReaderWriterEngineFactory_TransactionProviderTest : ExternalConnectionOrTransactionStrategyTestCases<TestingSqlDistributedReaderWriterLockEngineFactory, TransactionProvider> { }
    public class ExternalConnectionOrTransactionStrategy_SqlSemaphoreEngineFactory_ConnectionProviderTest : ExternalConnectionOrTransactionStrategyTestCases<TestingSqlDistributedSemaphoreEngineFactory, ConnectionProvider> { }
    public class ExternalConnectionOrTransactionStrategy_SqlSemaphoreEngineFactory_TransactionProviderTest : ExternalConnectionOrTransactionStrategyTestCases<TestingSqlDistributedSemaphoreEngineFactory, TransactionProvider> { }
}
