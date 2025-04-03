// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Models
{
    /// <summary>Specifies whether Telnyx is able to confirm portability this number in the United States &amp; Canada. International phone numbers are provisional by default.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum PortabilityStatus
    {
        [EnumMember(Value = "pending")]
        #pragma warning disable CS1591
        Pending,
        #pragma warning restore CS1591
        [EnumMember(Value = "confirmed")]
        #pragma warning disable CS1591
        Confirmed,
        #pragma warning restore CS1591
        [EnumMember(Value = "provisional")]
        #pragma warning disable CS1591
        Provisional,
        #pragma warning restore CS1591
    }
}
