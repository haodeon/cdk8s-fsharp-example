using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    #pragma warning disable CS8618

    /// <remarks>
    /// <strong>Schema</strong>: StackSpecFluxSourceSourceRef
    /// </remarks>
    [JsiiByValue(fqn: "compulumi.StackSpecFluxSourceSourceRef")]
    public class StackSpecFluxSourceSourceRef : Com.Pulumi.IStackSpecFluxSourceSourceRef
    {
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecFluxSourceSourceRef#apiVersion
        /// </remarks>
        [JsiiProperty(name: "apiVersion", typeJson: "{\"primitive\":\"string\"}")]
        public string ApiVersion
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Schema</strong>: StackSpecFluxSourceSourceRef#kind
        /// </remarks>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        public string Kind
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Schema</strong>: StackSpecFluxSourceSourceRef#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
