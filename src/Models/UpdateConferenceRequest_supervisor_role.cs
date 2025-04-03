// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Models
{
    /// <summary>Sets the participant as a supervisor for the conference. A conference can have multiple supervisors. &quot;barge&quot; means the supervisor enters the conference as a normal participant. This is the same as &quot;none&quot;. &quot;monitor&quot; means the supervisor is muted but can hear all participants. &quot;whisper&quot; means that only the specified &quot;whisper_call_control_ids&quot; can hear the supervisor. Defaults to &quot;none&quot;.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum UpdateConferenceRequest_supervisor_role
    {
        [EnumMember(Value = "barge")]
        #pragma warning disable CS1591
        Barge,
        #pragma warning restore CS1591
        [EnumMember(Value = "monitor")]
        #pragma warning disable CS1591
        Monitor,
        #pragma warning restore CS1591
        [EnumMember(Value = "none")]
        #pragma warning disable CS1591
        None,
        #pragma warning restore CS1591
        [EnumMember(Value = "whisper")]
        #pragma warning disable CS1591
        Whisper,
        #pragma warning restore CS1591
    }
}
