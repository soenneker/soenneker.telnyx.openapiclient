// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Models
{
    /// <summary>Specifies which track should be streamed.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum StartStreamingRequest_stream_track
    {
        [EnumMember(Value = "inbound_track")]
        #pragma warning disable CS1591
        Inbound_track,
        #pragma warning restore CS1591
        [EnumMember(Value = "outbound_track")]
        #pragma warning disable CS1591
        Outbound_track,
        #pragma warning restore CS1591
        [EnumMember(Value = "both_tracks")]
        #pragma warning disable CS1591
        Both_tracks,
        #pragma warning restore CS1591
    }
}
