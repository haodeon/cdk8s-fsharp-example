using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>NetworkPolicyPeer describes a peer to allow traffic to/from.</summary>
    /// <remarks>
    /// Only certain combinations of fields are allowed
    ///
    /// <strong>Schema</strong>: io.k8s.api.networking.v1.NetworkPolicyPeer
    /// </remarks>
    [JsiiInterface(nativeType: typeof(INetworkPolicyPeer), fullyQualifiedName: "k8s.NetworkPolicyPeer")]
    public interface INetworkPolicyPeer
    {
        /// <summary>ipBlock defines policy on a particular IPBlock.</summary>
        /// <remarks>
        /// If this field is set then neither of the other fields can be.
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.NetworkPolicyPeer#ipBlock
        /// </remarks>
        [JsiiProperty(name: "ipBlock", typeJson: "{\"fqn\":\"k8s.IpBlock\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IIpBlock? IpBlock
        {
            get
            {
                return null;
            }
        }

        /// <summary>namespaceSelector selects namespaces using cluster-scoped labels.</summary>
        /// <remarks>
        /// This field follows standard label selector semantics; if present but empty, it selects all namespaces.
        ///
        /// If podSelector is also set, then the NetworkPolicyPeer as a whole selects the pods matching podSelector in the namespaces selected by namespaceSelector. Otherwise it selects all pods in the namespaces selected by namespaceSelector.
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.NetworkPolicyPeer#namespaceSelector
        /// </remarks>
        [JsiiProperty(name: "namespaceSelector", typeJson: "{\"fqn\":\"k8s.LabelSelector\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ILabelSelector? NamespaceSelector
        {
            get
            {
                return null;
            }
        }

        /// <summary>podSelector is a label selector which selects pods.</summary>
        /// <remarks>
        /// This field follows standard label selector semantics; if present but empty, it selects all pods.
        ///
        /// If namespaceSelector is also set, then the NetworkPolicyPeer as a whole selects the pods matching podSelector in the Namespaces selected by NamespaceSelector. Otherwise it selects the pods matching podSelector in the policy's own namespace.
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.NetworkPolicyPeer#podSelector
        /// </remarks>
        [JsiiProperty(name: "podSelector", typeJson: "{\"fqn\":\"k8s.LabelSelector\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ILabelSelector? PodSelector
        {
            get
            {
                return null;
            }
        }

        /// <summary>NetworkPolicyPeer describes a peer to allow traffic to/from.</summary>
        /// <remarks>
        /// Only certain combinations of fields are allowed
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.NetworkPolicyPeer
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(INetworkPolicyPeer), fullyQualifiedName: "k8s.NetworkPolicyPeer")]
        internal sealed class _Proxy : DeputyBase, K8s.INetworkPolicyPeer
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ipBlock defines policy on a particular IPBlock.</summary>
            /// <remarks>
            /// If this field is set then neither of the other fields can be.
            ///
            /// <strong>Schema</strong>: io.k8s.api.networking.v1.NetworkPolicyPeer#ipBlock
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipBlock", typeJson: "{\"fqn\":\"k8s.IpBlock\"}", isOptional: true)]
            public K8s.IIpBlock? IpBlock
            {
                get => GetInstanceProperty<K8s.IIpBlock?>();
            }

            /// <summary>namespaceSelector selects namespaces using cluster-scoped labels.</summary>
            /// <remarks>
            /// This field follows standard label selector semantics; if present but empty, it selects all namespaces.
            ///
            /// If podSelector is also set, then the NetworkPolicyPeer as a whole selects the pods matching podSelector in the namespaces selected by namespaceSelector. Otherwise it selects all pods in the namespaces selected by namespaceSelector.
            ///
            /// <strong>Schema</strong>: io.k8s.api.networking.v1.NetworkPolicyPeer#namespaceSelector
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "namespaceSelector", typeJson: "{\"fqn\":\"k8s.LabelSelector\"}", isOptional: true)]
            public K8s.ILabelSelector? NamespaceSelector
            {
                get => GetInstanceProperty<K8s.ILabelSelector?>();
            }

            /// <summary>podSelector is a label selector which selects pods.</summary>
            /// <remarks>
            /// This field follows standard label selector semantics; if present but empty, it selects all pods.
            ///
            /// If namespaceSelector is also set, then the NetworkPolicyPeer as a whole selects the pods matching podSelector in the Namespaces selected by NamespaceSelector. Otherwise it selects the pods matching podSelector in the policy's own namespace.
            ///
            /// <strong>Schema</strong>: io.k8s.api.networking.v1.NetworkPolicyPeer#podSelector
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "podSelector", typeJson: "{\"fqn\":\"k8s.LabelSelector\"}", isOptional: true)]
            public K8s.ILabelSelector? PodSelector
            {
                get => GetInstanceProperty<K8s.ILabelSelector?>();
            }
        }
    }
}
