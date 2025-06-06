// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Models
{
    /// <summary>The operation type. It can be one of the following: &lt;br/&gt;&lt;ul&gt; &lt;li&gt;&lt;code&gt;enable&lt;/code&gt; - move the SIM card to the &lt;code&gt;enabled&lt;/code&gt; status&lt;/li&gt; &lt;li&gt;&lt;code&gt;enable_standby_sim_card&lt;/code&gt; - move a SIM card previously on the &lt;code&gt;standby&lt;/code&gt; status to the &lt;code&gt;enabled&lt;/code&gt; status after it consumes data.&lt;/li&gt; &lt;li&gt;&lt;code&gt;disable&lt;/code&gt; - move the SIM card to the &lt;code&gt;disabled&lt;/code&gt; status&lt;/li&gt; &lt;li&gt;&lt;code&gt;set_standby&lt;/code&gt; - move the SIM card to the &lt;code&gt;standby&lt;/code&gt; status&lt;/li&gt; &lt;/ul&gt;</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum SIMCardAction_action_type
    {
        [EnumMember(Value = "enable")]
        #pragma warning disable CS1591
        Enable,
        #pragma warning restore CS1591
        [EnumMember(Value = "enable_standby_sim_card")]
        #pragma warning disable CS1591
        Enable_standby_sim_card,
        #pragma warning restore CS1591
        [EnumMember(Value = "disable")]
        #pragma warning disable CS1591
        Disable,
        #pragma warning restore CS1591
        [EnumMember(Value = "set_standby")]
        #pragma warning disable CS1591
        Set_standby,
        #pragma warning restore CS1591
    }
}
