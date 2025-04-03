// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Models
{
    /// <summary>This feature enables inbound SIP URI calls to your Credential Auth Connection. If enabled for all (unrestricted) then anyone who calls the SIP URI &lt;your-username&gt;@telnyx.com will be connected to your Connection. You can also choose to allow only calls that are originated on any Connections under your account (internal).</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum CredentialConnection_sip_uri_calling_preference
    {
        [EnumMember(Value = "disabled")]
        #pragma warning disable CS1591
        Disabled,
        #pragma warning restore CS1591
        [EnumMember(Value = "unrestricted")]
        #pragma warning disable CS1591
        Unrestricted,
        #pragma warning restore CS1591
        [EnumMember(Value = "internal")]
        #pragma warning disable CS1591
        Internal,
        #pragma warning restore CS1591
    }
}
