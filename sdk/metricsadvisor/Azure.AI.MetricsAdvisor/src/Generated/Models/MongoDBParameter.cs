// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The MongoDBParameter. </summary>
    internal partial class MongoDBParameter
    {
        /// <summary> Initializes a new instance of MongoDBParameter. </summary>
        /// <param name="connectionString"> MongoDB connection string. </param>
        /// <param name="database"> Database name. </param>
        /// <param name="command"> Query script. </param>
        public MongoDBParameter(string connectionString, string database, string command)
        {
            ConnectionString = connectionString;
            Database = database;
            Command = command;
        }

        /// <summary> MongoDB connection string. </summary>
        public string ConnectionString { get; set; }
        /// <summary> Database name. </summary>
        public string Database { get; set; }
        /// <summary> Query script. </summary>
        public string Command { get; set; }
    }
}