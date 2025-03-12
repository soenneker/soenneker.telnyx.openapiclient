// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Soenneker.Telnyx.Models
{
    /// <summary>This setting only affects connections with Fax-type Outbound Voice Profiles. The setting dictates whether or not Telnyx sends a t.38 reinvite. By default, Telnyx will send the re-invite. If set to `customer`, the caller is expected to send the t.38 reinvite.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum OutboundFqdn_t38_reinvite_source
    {
        [EnumMember(Value = "telnyx")]
        #pragma warning disable CS1591
        Telnyx,
        #pragma warning restore CS1591
        [EnumMember(Value = "customer")]
        #pragma warning disable CS1591
        Customer,
        #pragma warning restore CS1591
        [EnumMember(Value = "disabled")]
        #pragma warning disable CS1591
        Disabled,
        #pragma warning restore CS1591
        [EnumMember(Value = "passthru")]
        #pragma warning disable CS1591
        Passthru,
        #pragma warning restore CS1591
        [EnumMember(Value = "caller-passthru")]
        #pragma warning disable CS1591
        CallerPassthru,
        #pragma warning restore CS1591
        [EnumMember(Value = "callee-passthru")]
        #pragma warning disable CS1591
        CalleePassthru,
        #pragma warning restore CS1591
    }
}
