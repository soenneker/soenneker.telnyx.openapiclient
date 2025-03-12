// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Soenneker.Telnyx.Models
{
    /// <summary>The audio track to be recorded. Can be either `both`, `inbound` or `outbound`. If only single track is specified (`inbound`, `outbound`), `channels` configuration is ignored and it will be recorded as mono (single channel).</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum StartRecordingRequest_recording_track
    {
        [EnumMember(Value = "both")]
        #pragma warning disable CS1591
        Both,
        #pragma warning restore CS1591
        [EnumMember(Value = "inbound")]
        #pragma warning disable CS1591
        Inbound,
        #pragma warning restore CS1591
        [EnumMember(Value = "outbound")]
        #pragma warning disable CS1591
        Outbound,
        #pragma warning restore CS1591
    }
}
