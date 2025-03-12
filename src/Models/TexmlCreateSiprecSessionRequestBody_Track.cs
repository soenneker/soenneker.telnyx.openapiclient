// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Soenneker.Telnyx.Models
{
    /// <summary>The track to be used for siprec session. Can be `both_tracks`, `inbound_track` or `outbound_track`. Defaults to `both_tracks`.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum TexmlCreateSiprecSessionRequestBody_Track
    {
        [EnumMember(Value = "both_tracks")]
        #pragma warning disable CS1591
        Both_tracks,
        #pragma warning restore CS1591
        [EnumMember(Value = "inbound_track")]
        #pragma warning disable CS1591
        Inbound_track,
        #pragma warning restore CS1591
        [EnumMember(Value = "outbound_track")]
        #pragma warning disable CS1591
        Outbound_track,
        #pragma warning restore CS1591
    }
}
