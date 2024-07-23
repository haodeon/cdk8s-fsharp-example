using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>HostAlias holds the mapping between IP and hostnames that will be injected as an entry in the pod's hosts file.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.HostAlias
    /// </remarks>
    [JsiiByValue(fqn: "k8s.HostAlias")]
    public class HostAlias : K8s.IHostAlias
    {
        /// <summary>Hostnames for the above IP address.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.HostAlias#hostnames
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hostnames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Hostnames
        {
            get;
            set;
        }

        /// <summary>IP address of the host file entry.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.HostAlias#ip
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ip
        {
            get;
            set;
        }
    }
}
