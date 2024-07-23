using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>NetworkPolicyEgressRule describes a particular set of traffic that is allowed out of pods matched by a NetworkPolicySpec's podSelector.</summary>
    /// <remarks>
    /// The traffic must match both ports and to. This type is beta-level in 1.8
    ///
    /// <strong>Schema</strong>: io.k8s.api.networking.v1.NetworkPolicyEgressRule
    /// </remarks>
    [JsiiInterface(nativeType: typeof(INetworkPolicyEgressRule), fullyQualifiedName: "k8s.NetworkPolicyEgressRule")]
    public interface INetworkPolicyEgressRule
    {
        /// <summary>ports is a list of destination ports for outgoing traffic.</summary>
        /// <remarks>
        /// Each item in this list is combined using a logical OR. If this field is empty or missing, this rule matches all ports (traffic not restricted by port). If this field is present and contains at least one item, then this rule allows traffic only if the traffic matches at least one port in the list.
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.NetworkPolicyEgressRule#ports
        /// </remarks>
        [JsiiProperty(name: "ports", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.NetworkPolicyPort\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.INetworkPolicyPort[]? Ports
        {
            get
            {
                return null;
            }
        }

        /// <summary>to is a list of destinations for outgoing traffic of pods selected for this rule.</summary>
        /// <remarks>
        /// Items in this list are combined using a logical OR operation. If this field is empty or missing, this rule matches all destinations (traffic not restricted by destination). If this field is present and contains at least one item, this rule allows traffic only if the traffic matches at least one item in the to list.
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.NetworkPolicyEgressRule#to
        /// </remarks>
        [JsiiProperty(name: "to", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.NetworkPolicyPeer\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.INetworkPolicyPeer[]? To
        {
            get
            {
                return null;
            }
        }

        /// <summary>NetworkPolicyEgressRule describes a particular set of traffic that is allowed out of pods matched by a NetworkPolicySpec's podSelector.</summary>
        /// <remarks>
        /// The traffic must match both ports and to. This type is beta-level in 1.8
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.NetworkPolicyEgressRule
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(INetworkPolicyEgressRule), fullyQualifiedName: "k8s.NetworkPolicyEgressRule")]
        internal sealed class _Proxy : DeputyBase, K8s.INetworkPolicyEgressRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ports is a list of destination ports for outgoing traffic.</summary>
            /// <remarks>
            /// Each item in this list is combined using a logical OR. If this field is empty or missing, this rule matches all ports (traffic not restricted by port). If this field is present and contains at least one item, then this rule allows traffic only if the traffic matches at least one port in the list.
            ///
            /// <strong>Schema</strong>: io.k8s.api.networking.v1.NetworkPolicyEgressRule#ports
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ports", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.NetworkPolicyPort\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.INetworkPolicyPort[]? Ports
            {
                get => GetInstanceProperty<K8s.INetworkPolicyPort[]?>();
            }

            /// <summary>to is a list of destinations for outgoing traffic of pods selected for this rule.</summary>
            /// <remarks>
            /// Items in this list are combined using a logical OR operation. If this field is empty or missing, this rule matches all destinations (traffic not restricted by destination). If this field is present and contains at least one item, this rule allows traffic only if the traffic matches at least one item in the to list.
            ///
            /// <strong>Schema</strong>: io.k8s.api.networking.v1.NetworkPolicyEgressRule#to
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "to", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.NetworkPolicyPeer\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.INetworkPolicyPeer[]? To
            {
                get => GetInstanceProperty<K8s.INetworkPolicyPeer[]?>();
            }
        }
    }
}
