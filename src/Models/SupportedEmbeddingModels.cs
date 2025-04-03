// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Soenneker.Telnyx.OpenApiClient.Models
{
    /// <summary>Supported models to vectorize and embed documents.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum SupportedEmbeddingModels
    {
        [EnumMember(Value = "thenlper/gte-large")]
        #pragma warning disable CS1591
        ThenlperGteLarge,
        #pragma warning restore CS1591
        [EnumMember(Value = "intfloat/multilingual-e5-large")]
        #pragma warning disable CS1591
        IntfloatMultilingualE5Large,
        #pragma warning restore CS1591
        [EnumMember(Value = "sentence-transformers/all-mpnet-base-v2")]
        #pragma warning disable CS1591
        SentenceTransformersAllMpnetBaseV2,
        #pragma warning restore CS1591
    }
}
