// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Models
{
    /// <summary>The phone number&apos;s current status.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum PhoneNumberDeletedDetailed_status
    {
        [EnumMember(Value = "purchase-pending")]
        #pragma warning disable CS1591
        PurchasePending,
        #pragma warning restore CS1591
        [EnumMember(Value = "purchase-failed")]
        #pragma warning disable CS1591
        PurchaseFailed,
        #pragma warning restore CS1591
        [EnumMember(Value = "port-pending")]
        #pragma warning disable CS1591
        PortPending,
        #pragma warning restore CS1591
        [EnumMember(Value = "port-failed")]
        #pragma warning disable CS1591
        PortFailed,
        #pragma warning restore CS1591
        [EnumMember(Value = "active")]
        #pragma warning disable CS1591
        Active,
        #pragma warning restore CS1591
        [EnumMember(Value = "deleted")]
        #pragma warning disable CS1591
        Deleted,
        #pragma warning restore CS1591
        [EnumMember(Value = "emergency-only")]
        #pragma warning disable CS1591
        EmergencyOnly,
        #pragma warning restore CS1591
        [EnumMember(Value = "ported-out")]
        #pragma warning disable CS1591
        PortedOut,
        #pragma warning restore CS1591
        [EnumMember(Value = "port-out-pending")]
        #pragma warning disable CS1591
        PortOutPending,
        #pragma warning restore CS1591
    }
}
