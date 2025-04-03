// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Models
{
    /// <summary>RTCP port by default is rtp+1, it can also be set to rtcp-mux</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum ConnectionRtcpSettings_port
    {
        [EnumMember(Value = "rtcp-mux")]
        #pragma warning disable CS1591
        RtcpMux,
        #pragma warning restore CS1591
        [EnumMember(Value = "rtp+1")]
        #pragma warning disable CS1591
        Rtp_plus_1,
        #pragma warning restore CS1591
    }
}
