// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Management.Sql.LegacySdk.Models
{
    /// <summary>
    /// Represents time series data of any metrics of this Recommended Action
    /// </summary>
    public partial class RecommendedActionMetricInfo
    {
        private string _metricName;
        
        /// <summary>
        /// Optional. Gets the name of the metric. E.g., CPU, Number of Queries.
        /// </summary>
        public string MetricName
        {
            get { return this._metricName; }
            set { this._metricName = value; }
        }
        
        private System.DateTime? _startTime;
        
        /// <summary>
        /// Optional. Gets the start time of time interval given by this
        /// MetricInfo
        /// </summary>
        public System.DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }
        
        private string _timeGrain;
        
        /// <summary>
        /// Optional. Gets the duration of time interval for the value given by
        /// this MetricInfo E.g., PT1H (1 hour)
        /// </summary>
        public string TimeGrain
        {
            get { return this._timeGrain; }
            set { this._timeGrain = value; }
        }
        
        private string _unit;
        
        /// <summary>
        /// Optional. Gets the unit in which metric is measured. E.g., DTU,
        /// Frequency
        /// </summary>
        public string Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }
        
        private double? _value;
        
        /// <summary>
        /// Optional. Gets the value of the metric in the time interval given
        /// by this MetricInfo
        /// </summary>
        public double? Value
        {
            get { return this._value; }
            set { this._value = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the RecommendedActionMetricInfo class.
        /// </summary>
        public RecommendedActionMetricInfo()
        {
        }
    }
}
