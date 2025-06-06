// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Models
{
    /// <summary>Cloud provider from which to migrate data. Use &apos;telnyx&apos; if you want to migrate data from one Telnyx bucket to another.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum MigrationSourceParams_provider
    {
        [EnumMember(Value = "aws")]
        #pragma warning disable CS1591
        Aws,
        #pragma warning restore CS1591
        [EnumMember(Value = "telnyx")]
        #pragma warning disable CS1591
        Telnyx,
        #pragma warning restore CS1591
    }
}
