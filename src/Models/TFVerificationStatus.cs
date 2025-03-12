// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Soenneker.Telnyx.Models
{
    /// <summary>Tollfree verification status</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum TFVerificationStatus
    {
        [EnumMember(Value = "Verified")]
        #pragma warning disable CS1591
        Verified,
        #pragma warning restore CS1591
        [EnumMember(Value = "Rejected")]
        #pragma warning disable CS1591
        Rejected,
        #pragma warning restore CS1591
        [EnumMember(Value = "Waiting For Vendor")]
        #pragma warning disable CS1591
        WaitingForVendor,
        #pragma warning restore CS1591
        [EnumMember(Value = "Waiting For Customer")]
        #pragma warning disable CS1591
        WaitingForCustomer,
        #pragma warning restore CS1591
        [EnumMember(Value = "Waiting For Telnyx")]
        #pragma warning disable CS1591
        WaitingForTelnyx,
        #pragma warning restore CS1591
        [EnumMember(Value = "In Progress")]
        #pragma warning disable CS1591
        InProgress,
        #pragma warning restore CS1591
    }
}
