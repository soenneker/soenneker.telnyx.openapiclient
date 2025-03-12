// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Soenneker.Telnyx.Models
{
    /// <summary>This setting allows you to set the format with which the caller&apos;s number (ANI) is sent for inbound phone calls.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum InboundIp_ani_number_format
    {
        [EnumMember(Value = "+E.164")]
        #pragma warning disable CS1591
        Plus_E164,
        #pragma warning restore CS1591
        [EnumMember(Value = "E.164")]
        #pragma warning disable CS1591
        E164,
        #pragma warning restore CS1591
        [EnumMember(Value = "+E.164-national")]
        #pragma warning disable CS1591
        Plus_E164National,
        #pragma warning restore CS1591
        [EnumMember(Value = "E.164-national")]
        #pragma warning disable CS1591
        E164National,
        #pragma warning restore CS1591
    }
}
