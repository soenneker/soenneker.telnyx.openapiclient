// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Soenneker.Telnyx.Models
{
    /// <summary>Status of an embeddings task.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum BackgroundTaskStatus
    {
        [EnumMember(Value = "queued")]
        #pragma warning disable CS1591
        Queued,
        #pragma warning restore CS1591
        [EnumMember(Value = "processing")]
        #pragma warning disable CS1591
        Processing,
        #pragma warning restore CS1591
        [EnumMember(Value = "success")]
        #pragma warning disable CS1591
        Success,
        #pragma warning restore CS1591
        [EnumMember(Value = "failure")]
        #pragma warning disable CS1591
        Failure,
        #pragma warning restore CS1591
        [EnumMember(Value = "partial_success")]
        #pragma warning disable CS1591
        Partial_success,
        #pragma warning restore CS1591
    }
}
