using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Adds and removes POSIX capabilities from running containers.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.Capabilities
    /// </remarks>
    [JsiiByValue(fqn: "k8s.Capabilities")]
    public class Capabilities : K8s.ICapabilities
    {
        /// <summary>Added capabilities.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Capabilities#add
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "add", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Add
        {
            get;
            set;
        }

        /// <summary>Removed capabilities.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Capabilities#drop
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "drop", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Drop
        {
            get;
            set;
        }
    }
}
