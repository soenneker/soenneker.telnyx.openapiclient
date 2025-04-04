// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Models
{
    /// <summary>Optionally specify a `stream_type`. This should match the `stream_type` that was used in `fork_start` command to properly stop the fork.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum StopForkingRequest_stream_type
    {
        [EnumMember(Value = "raw")]
        #pragma warning disable CS1591
        Raw,
        #pragma warning restore CS1591
        [EnumMember(Value = "decrypted")]
        #pragma warning disable CS1591
        Decrypted,
        #pragma warning restore CS1591
    }
}
