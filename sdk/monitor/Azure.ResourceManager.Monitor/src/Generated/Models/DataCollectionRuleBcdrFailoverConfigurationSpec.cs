// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The DataCollectionRuleBcdrFailoverConfigurationSpec. </summary>
    public partial class DataCollectionRuleBcdrFailoverConfigurationSpec
    {
        /// <summary> Initializes a new instance of DataCollectionRuleBcdrFailoverConfigurationSpec. </summary>
        internal DataCollectionRuleBcdrFailoverConfigurationSpec()
        {
            Locations = new ChangeTrackingList<DataCollectionRuleBcdrLocationSpec>();
        }

        /// <summary> Initializes a new instance of DataCollectionRuleBcdrFailoverConfigurationSpec. </summary>
        /// <param name="activeLocation"> Active location where data flow will occur. </param>
        /// <param name="locations"> Locations that are configured for failover. </param>
        internal DataCollectionRuleBcdrFailoverConfigurationSpec(string activeLocation, IReadOnlyList<DataCollectionRuleBcdrLocationSpec> locations)
        {
            ActiveLocation = activeLocation;
            Locations = locations;
        }

        /// <summary> Active location where data flow will occur. </summary>
        public string ActiveLocation { get; }
        /// <summary> Locations that are configured for failover. </summary>
        public IReadOnlyList<DataCollectionRuleBcdrLocationSpec> Locations { get; }
    }
}
