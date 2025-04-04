// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Models
{
    /// <summary>Enables Answering Machine Detection. When a call is answered, Telnyx runs real-time detection to determine if it was picked up by a human or a machine and sends an `call.machine.detection.ended` webhook with the analysis result. If &apos;greeting_end&apos; or &apos;detect_words&apos; is used and a &apos;machine&apos; is detected, you will receive another &apos;call.machine.greeting.ended&apos; webhook when the answering machine greeting ends with a beep or silence. If `detect_beep` is used, you will only receive &apos;call.machine.greeting.ended&apos; if a beep is detected.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum TransferCallRequest_answering_machine_detection
    {
        [EnumMember(Value = "premium")]
        #pragma warning disable CS1591
        Premium,
        #pragma warning restore CS1591
        [EnumMember(Value = "detect")]
        #pragma warning disable CS1591
        Detect,
        #pragma warning restore CS1591
        [EnumMember(Value = "detect_beep")]
        #pragma warning disable CS1591
        Detect_beep,
        #pragma warning restore CS1591
        [EnumMember(Value = "detect_words")]
        #pragma warning disable CS1591
        Detect_words,
        #pragma warning restore CS1591
        [EnumMember(Value = "greeting_end")]
        #pragma warning disable CS1591
        Greeting_end,
        #pragma warning restore CS1591
        [EnumMember(Value = "disabled")]
        #pragma warning disable CS1591
        Disabled,
        #pragma warning restore CS1591
    }
}
