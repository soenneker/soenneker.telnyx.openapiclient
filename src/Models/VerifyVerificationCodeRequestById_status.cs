// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Models
{
    /// <summary>Identifies if the verification code has been accepted or rejected. Only permitted if custom_code was used for the verification.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum VerifyVerificationCodeRequestById_status
    {
        [EnumMember(Value = "accepted")]
        #pragma warning disable CS1591
        Accepted,
        #pragma warning restore CS1591
        [EnumMember(Value = "rejected")]
        #pragma warning disable CS1591
        Rejected,
        #pragma warning restore CS1591
    }
}
