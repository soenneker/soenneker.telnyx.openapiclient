// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Models
{
    /// <summary>Remaining numbers can be either kept with their current service provider or disconnected. &apos;new_billing_telephone_number&apos; is required when &apos;remaining_numbers_action&apos; is &apos;keep&apos;.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum PortingOrderMisc_remaining_numbers_action
    {
        [EnumMember(Value = "keep")]
        #pragma warning disable CS1591
        Keep,
        #pragma warning restore CS1591
        [EnumMember(Value = "disconnect")]
        #pragma warning disable CS1591
        Disconnect,
        #pragma warning restore CS1591
    }
}
