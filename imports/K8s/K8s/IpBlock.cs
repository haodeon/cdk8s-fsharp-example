using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>IPBlock describes a particular CIDR (Ex.</summary>
    /// <remarks>
    /// "192.168.1.0/24","2001:db8::/64") that is allowed to the pods matched by a NetworkPolicySpec's podSelector. The except entry describes CIDRs that should not be included within this rule.
    ///
    /// <strong>Schema</strong>: io.k8s.api.networking.v1.IPBlock
    /// </remarks>
    [JsiiByValue(fqn: "k8s.IpBlock")]
    public class IpBlock : K8s.IIpBlock
    {
        /// <summary>cidr is a string representing the IPBlock Valid examples are "192.168.1.0/24" or "2001:db8::/64".</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.IPBlock#cidr
        /// </remarks>
        [JsiiProperty(name: "cidr", typeJson: "{\"primitive\":\"string\"}")]
        public string Cidr
        {
            get;
            set;
        }

        /// <summary>except is a slice of CIDRs that should not be included within an IPBlock Valid examples are "192.168.1.0/24" or "2001:db8::/64" Except values will be rejected if they are outside the cidr range.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.IPBlock#except
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "except", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Except
        {
            get;
            set;
        }
    }
}
