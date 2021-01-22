// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A long term retention policy. </summary>
    public partial class BackupLongTermRetentionPolicy : ProxyResource
    {
        /// <summary> Initializes a new instance of BackupLongTermRetentionPolicy. </summary>
        public BackupLongTermRetentionPolicy()
        {
        }

        /// <summary> Initializes a new instance of BackupLongTermRetentionPolicy. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="weeklyRetention"> The weekly retention policy for an LTR backup in an ISO 8601 format. </param>
        /// <param name="monthlyRetention"> The monthly retention policy for an LTR backup in an ISO 8601 format. </param>
        /// <param name="yearlyRetention"> The yearly retention policy for an LTR backup in an ISO 8601 format. </param>
        /// <param name="weekOfYear"> The week of year to take the yearly backup in an ISO 8601 format. </param>
        internal BackupLongTermRetentionPolicy(string id, string name, string type, string weeklyRetention, string monthlyRetention, string yearlyRetention, int? weekOfYear) : base(id, name, type)
        {
            WeeklyRetention = weeklyRetention;
            MonthlyRetention = monthlyRetention;
            YearlyRetention = yearlyRetention;
            WeekOfYear = weekOfYear;
        }

        /// <summary> The weekly retention policy for an LTR backup in an ISO 8601 format. </summary>
        public string WeeklyRetention { get; set; }
        /// <summary> The monthly retention policy for an LTR backup in an ISO 8601 format. </summary>
        public string MonthlyRetention { get; set; }
        /// <summary> The yearly retention policy for an LTR backup in an ISO 8601 format. </summary>
        public string YearlyRetention { get; set; }
        /// <summary> The week of year to take the yearly backup in an ISO 8601 format. </summary>
        public int? WeekOfYear { get; set; }
    }
}