// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Soenneker.Telnyx.Models
{
    /// <summary>This option can be enabled to receive calls from: &quot;Anyone&quot; (any SIP endpoint in the public Internet) or &quot;Only my connections&quot; (any connection assigned to the same Telnyx user).</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum TexmlApplication_inbound_sip_subdomain_receive_settings
    {
        [EnumMember(Value = "only_my_connections")]
        #pragma warning disable CS1591
        Only_my_connections,
        #pragma warning restore CS1591
        [EnumMember(Value = "from_anyone")]
        #pragma warning disable CS1591
        From_anyone,
        #pragma warning restore CS1591
    }
}
