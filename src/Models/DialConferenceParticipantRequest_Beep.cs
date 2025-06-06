// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Models
{
    /// <summary>Whether to play a notification beep to the conference when the participant enters and exits.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum DialConferenceParticipantRequest_Beep
    {
        [EnumMember(Value = "true")]
        #pragma warning disable CS1591
        True,
        #pragma warning restore CS1591
        [EnumMember(Value = "false")]
        #pragma warning disable CS1591
        False,
        #pragma warning restore CS1591
        [EnumMember(Value = "onEnter")]
        #pragma warning disable CS1591
        OnEnter,
        #pragma warning restore CS1591
        [EnumMember(Value = "onExit")]
        #pragma warning disable CS1591
        OnExit,
        #pragma warning restore CS1591
    }
}
