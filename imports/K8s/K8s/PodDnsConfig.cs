using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>PodDNSConfig defines the DNS parameters of a pod in addition to those generated from DNSPolicy.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.PodDNSConfig
    /// </remarks>
    [JsiiByValue(fqn: "k8s.PodDnsConfig")]
    public class PodDnsConfig : K8s.IPodDnsConfig
    {
        /// <summary>A list of DNS name server IP addresses.</summary>
        /// <remarks>
        /// This will be appended to the base nameservers generated from DNSPolicy. Duplicated nameservers will be removed.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodDNSConfig#nameservers
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nameservers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Nameservers
        {
            get;
            set;
        }

        /// <summary>A list of DNS resolver options.</summary>
        /// <remarks>
        /// This will be merged with the base options generated from DNSPolicy. Duplicated entries will be removed. Resolution options given in Options will override those that appear in the base DNSPolicy.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodDNSConfig#options
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "options", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.PodDnsConfigOption\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.IPodDnsConfigOption[]? Options
        {
            get;
            set;
        }

        /// <summary>A list of DNS search domains for host-name lookup.</summary>
        /// <remarks>
        /// This will be appended to the base search paths generated from DNSPolicy. Duplicated search paths will be removed.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodDNSConfig#searches
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "searches", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Searches
        {
            get;
            set;
        }
    }
}
