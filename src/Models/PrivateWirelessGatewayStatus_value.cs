// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Soenneker.Telnyx.Models
{
    /// <summary>The current status or failure details of the Private Wireless Gateway. &lt;ul&gt; &lt;li&gt;&lt;code&gt;provisioning&lt;/code&gt; - the Private Wireless Gateway is being provisioned.&lt;/li&gt; &lt;li&gt;&lt;code&gt;provisioned&lt;/code&gt; - the Private Wireless Gateway was provisioned and able to receive connections.&lt;/li&gt; &lt;li&gt;&lt;code&gt;failed&lt;/code&gt; - the provisioning had failed for a reason and it requires an intervention.&lt;/li&gt; &lt;li&gt;&lt;code&gt;decommissioning&lt;/code&gt; - the Private Wireless Gateway is being removed from the network.&lt;/li&gt; &lt;/ul&gt; Transitioning between the provisioning and provisioned states may take some time.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum PrivateWirelessGatewayStatus_value
    {
        [EnumMember(Value = "provisioning")]
        #pragma warning disable CS1591
        Provisioning,
        #pragma warning restore CS1591
        [EnumMember(Value = "provisioned")]
        #pragma warning disable CS1591
        Provisioned,
        #pragma warning restore CS1591
        [EnumMember(Value = "failed")]
        #pragma warning disable CS1591
        Failed,
        #pragma warning restore CS1591
        [EnumMember(Value = "decommissioning")]
        #pragma warning disable CS1591
        Decommissioning,
        #pragma warning restore CS1591
    }
}
