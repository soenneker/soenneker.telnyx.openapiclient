// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Soenneker.Telnyx.Phone_number_campaigns
{
    /// <summary>Specifies the sort order for results. If not given, results are sorted by created_at in descending order.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum GetSortQueryParameterType
    {
        [EnumMember(Value = "assignmentStatus")]
        #pragma warning disable CS1591
        AssignmentStatus,
        #pragma warning restore CS1591
        [EnumMember(Value = "-assignmentStatus")]
        #pragma warning disable CS1591
        Minus_assignmentStatus,
        #pragma warning restore CS1591
        [EnumMember(Value = "createdAt")]
        #pragma warning disable CS1591
        CreatedAt,
        #pragma warning restore CS1591
        [EnumMember(Value = "-createdAt")]
        #pragma warning disable CS1591
        Minus_createdAt,
        #pragma warning restore CS1591
        [EnumMember(Value = "phoneNumber")]
        #pragma warning disable CS1591
        PhoneNumber,
        #pragma warning restore CS1591
        [EnumMember(Value = "-phoneNumber")]
        #pragma warning disable CS1591
        Minus_phoneNumber,
        #pragma warning restore CS1591
    }
}
