using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>PodDNSConfigOption defines DNS resolver options of a pod.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.PodDNSConfigOption
    /// </remarks>
    [JsiiByValue(fqn: "k8s.PodDnsConfigOption")]
    public class PodDnsConfigOption : K8s.IPodDnsConfigOption
    {
        /// <summary>Required.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodDNSConfigOption#name
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodDNSConfigOption#value
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Value
        {
            get;
            set;
        }
    }
}
