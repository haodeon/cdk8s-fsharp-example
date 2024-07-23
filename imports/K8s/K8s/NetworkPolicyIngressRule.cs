using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>NetworkPolicyIngressRule describes a particular set of traffic that is allowed to the pods matched by a NetworkPolicySpec's podSelector.</summary>
    /// <remarks>
    /// The traffic must match both ports and from.
    ///
    /// <strong>Schema</strong>: io.k8s.api.networking.v1.NetworkPolicyIngressRule
    /// </remarks>
    [JsiiByValue(fqn: "k8s.NetworkPolicyIngressRule")]
    public class NetworkPolicyIngressRule : K8s.INetworkPolicyIngressRule
    {
        /// <summary>from is a list of sources which should be able to access the pods selected for this rule.</summary>
        /// <remarks>
        /// Items in this list are combined using a logical OR operation. If this field is empty or missing, this rule matches all sources (traffic not restricted by source). If this field is present and contains at least one item, this rule allows traffic only if the traffic matches at least one item in the from list.
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.NetworkPolicyIngressRule#from
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "from", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.NetworkPolicyPeer\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.INetworkPolicyPeer[]? From
        {
            get;
            set;
        }

        /// <summary>ports is a list of ports which should be made accessible on the pods selected for this rule.</summary>
        /// <remarks>
        /// Each item in this list is combined using a logical OR. If this field is empty or missing, this rule matches all ports (traffic not restricted by port). If this field is present and contains at least one item, then this rule allows traffic only if the traffic matches at least one port in the list.
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.NetworkPolicyIngressRule#ports
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ports", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.NetworkPolicyPort\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.INetworkPolicyPort[]? Ports
        {
            get;
            set;
        }
    }
}
