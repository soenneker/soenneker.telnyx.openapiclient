// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Soenneker.Telnyx.Models
{
    /// <summary>Whether to record the conference the participant is joining. Defualts to `do-not-record`. The boolean values `true` and `false` are synonymous with `record-from-start` and `do-not-record` respectively.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum DialConferenceParticipantRequest_ConferenceRecord
    {
        [EnumMember(Value = "true")]
        #pragma warning disable CS1591
        True,
        #pragma warning restore CS1591
        [EnumMember(Value = "false")]
        #pragma warning disable CS1591
        False,
        #pragma warning restore CS1591
        [EnumMember(Value = "record-from-start")]
        #pragma warning disable CS1591
        RecordFromStart,
        #pragma warning restore CS1591
        [EnumMember(Value = "do-not-record")]
        #pragma warning disable CS1591
        DoNotRecord,
        #pragma warning restore CS1591
    }
}
