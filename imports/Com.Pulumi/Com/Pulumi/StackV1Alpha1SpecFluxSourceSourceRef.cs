using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    #pragma warning disable CS8618

    /// <remarks>
    /// <strong>Schema</strong>: StackV1Alpha1SpecFluxSourceSourceRef
    /// </remarks>
    [JsiiByValue(fqn: "compulumi.StackV1Alpha1SpecFluxSourceSourceRef")]
    public class StackV1Alpha1SpecFluxSourceSourceRef : Com.Pulumi.IStackV1Alpha1SpecFluxSourceSourceRef
    {
        /// <remarks>
        /// <strong>Schema</strong>: StackV1Alpha1SpecFluxSourceSourceRef#apiVersion
        /// </remarks>
        [JsiiProperty(name: "apiVersion", typeJson: "{\"primitive\":\"string\"}")]
        public string ApiVersion
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Schema</strong>: StackV1Alpha1SpecFluxSourceSourceRef#kind
        /// </remarks>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        public string Kind
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Schema</strong>: StackV1Alpha1SpecFluxSourceSourceRef#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
