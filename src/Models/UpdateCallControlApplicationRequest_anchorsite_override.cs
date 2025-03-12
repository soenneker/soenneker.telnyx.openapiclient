// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Soenneker.Telnyx.Models
{
    /// <summary>&lt;code&gt;Latency&lt;/code&gt; directs Telnyx to route media through the site with the lowest round-trip time to the user&apos;s connection. Telnyx calculates this time using ICMP ping messages. This can be disabled by specifying a site to handle all media.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum UpdateCallControlApplicationRequest_anchorsite_override
    {
        [EnumMember(Value = "Latency")]
        #pragma warning disable CS1591
        Latency,
        #pragma warning restore CS1591
        [EnumMember(Value = "Chicago, IL")]
        #pragma warning disable CS1591
        ChicagoIL,
        #pragma warning restore CS1591
        [EnumMember(Value = "Ashburn, VA")]
        #pragma warning disable CS1591
        AshburnVA,
        #pragma warning restore CS1591
        [EnumMember(Value = "San Jose, CA")]
        #pragma warning disable CS1591
        SanJoseCA,
        #pragma warning restore CS1591
    }
}
