// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Properties of the FirewallPolicyFilterRuleAction. </summary>
    public partial class FirewallPolicyFilterRuleAction
    {
        /// <summary> Initializes a new instance of FirewallPolicyFilterRuleAction. </summary>
        public FirewallPolicyFilterRuleAction()
        {
        }

        /// <summary> Initializes a new instance of FirewallPolicyFilterRuleAction. </summary>
        /// <param name="type"> The type of action. </param>
        internal FirewallPolicyFilterRuleAction(FirewallPolicyFilterRuleActionType? type)
        {
            Type = type;
        }

        /// <summary> The type of action. </summary>
        public FirewallPolicyFilterRuleActionType? Type { get; set; }
    }
}
