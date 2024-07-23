using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    #pragma warning disable CS8618

    /// <summary>LiteralRef refers to a literal value.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: StackV1Alpha1SpecSecretsRefLiteral
    /// </remarks>
    [JsiiByValue(fqn: "compulumi.StackV1Alpha1SpecSecretsRefLiteral")]
    public class StackV1Alpha1SpecSecretsRefLiteral : Com.Pulumi.IStackV1Alpha1SpecSecretsRefLiteral
    {
        /// <summary>Value to load.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackV1Alpha1SpecSecretsRefLiteral#value
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
