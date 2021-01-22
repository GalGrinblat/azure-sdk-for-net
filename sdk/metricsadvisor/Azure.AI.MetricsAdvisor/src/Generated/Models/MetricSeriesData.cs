// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The MetricDataItem. </summary>
    public partial class MetricSeriesData
    {
        /// <summary> Initializes a new instance of MetricSeriesData. </summary>
        /// <param name="definition"> . </param>
        /// <param name="timestamps"> timestamps of the data related to this time series. </param>
        /// <param name="values"> values of the data related to this time series. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="definition"/>, <paramref name="timestamps"/>, or <paramref name="values"/> is null. </exception>
        internal MetricSeriesData(MetricSeriesDefinition definition, IEnumerable<DateTimeOffset> timestamps, IEnumerable<double> values)
        {
            if (definition == null)
            {
                throw new ArgumentNullException(nameof(definition));
            }
            if (timestamps == null)
            {
                throw new ArgumentNullException(nameof(timestamps));
            }
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            Definition = definition;
            Timestamps = timestamps.ToList();
            Values = values.ToList();
        }

        /// <summary> Initializes a new instance of MetricSeriesData. </summary>
        /// <param name="definition"> . </param>
        /// <param name="timestamps"> timestamps of the data related to this time series. </param>
        /// <param name="values"> values of the data related to this time series. </param>
        internal MetricSeriesData(MetricSeriesDefinition definition, IReadOnlyList<DateTimeOffset> timestamps, IReadOnlyList<double> values)
        {
            Definition = definition;
            Timestamps = timestamps;
            Values = values;
        }
    }
}