// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Soenneker.Telnyx.Models
{
    /// <summary>One of UDP, TLS, or TCP. Applies only to connections with IP authentication or FQDN authentication.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum UpdateIpConnectionRequest_transport_protocol
    {
        [EnumMember(Value = "UDP")]
        #pragma warning disable CS1591
        UDP,
        #pragma warning restore CS1591
        [EnumMember(Value = "TCP")]
        #pragma warning disable CS1591
        TCP,
        #pragma warning restore CS1591
        [EnumMember(Value = "TLS")]
        #pragma warning disable CS1591
        TLS,
        #pragma warning restore CS1591
    }
}
