using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>NetworkPolicySpec provides the specification of a NetworkPolicy.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.networking.v1.NetworkPolicySpec
    /// </remarks>
    [JsiiInterface(nativeType: typeof(INetworkPolicySpec), fullyQualifiedName: "k8s.NetworkPolicySpec")]
    public interface INetworkPolicySpec
    {
        /// <summary>podSelector selects the pods to which this NetworkPolicy object applies.</summary>
        /// <remarks>
        /// The array of ingress rules is applied to any pods selected by this field. Multiple network policies can select the same set of pods. In this case, the ingress rules for each are combined additively. This field is NOT optional and follows standard label selector semantics. An empty podSelector matches all pods in this namespace.
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.NetworkPolicySpec#podSelector
        /// </remarks>
        [JsiiProperty(name: "podSelector", typeJson: "{\"fqn\":\"k8s.LabelSelector\"}")]
        K8s.ILabelSelector PodSelector
        {
            get;
        }

        /// <summary>egress is a list of egress rules to be applied to the selected pods.</summary>
        /// <remarks>
        /// Outgoing traffic is allowed if there are no NetworkPolicies selecting the pod (and cluster policy otherwise allows the traffic), OR if the traffic matches at least one egress rule across all of the NetworkPolicy objects whose podSelector matches the pod. If this field is empty then this NetworkPolicy limits all outgoing traffic (and serves solely to ensure that the pods it selects are isolated by default). This field is beta-level in 1.8
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.NetworkPolicySpec#egress
        /// </remarks>
        [JsiiProperty(name: "egress", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.NetworkPolicyEgressRule\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.INetworkPolicyEgressRule[]? Egress
        {
            get
            {
                return null;
            }
        }

        /// <summary>ingress is a list of ingress rules to be applied to the selected pods.</summary>
        /// <remarks>
        /// Traffic is allowed to a pod if there are no NetworkPolicies selecting the pod (and cluster policy otherwise allows the traffic), OR if the traffic source is the pod's local node, OR if the traffic matches at least one ingress rule across all of the NetworkPolicy objects whose podSelector matches the pod. If this field is empty then this NetworkPolicy does not allow any traffic (and serves solely to ensure that the pods it selects are isolated by default)
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.NetworkPolicySpec#ingress
        /// </remarks>
        [JsiiProperty(name: "ingress", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.NetworkPolicyIngressRule\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.INetworkPolicyIngressRule[]? Ingress
        {
            get
            {
                return null;
            }
        }

        /// <summary>policyTypes is a list of rule types that the NetworkPolicy relates to.</summary>
        /// <remarks>
        /// Valid options are ["Ingress"], ["Egress"], or ["Ingress", "Egress"]. If this field is not specified, it will default based on the existence of ingress or egress rules; policies that contain an egress section are assumed to affect egress, and all policies (whether or not they contain an ingress section) are assumed to affect ingress. If you want to write an egress-only policy, you must explicitly specify policyTypes [ "Egress" ]. Likewise, if you want to write a policy that specifies that no egress is allowed, you must specify a policyTypes value that include "Egress" (since such a policy would not include an egress section and would otherwise default to just [ "Ingress" ]). This field is beta-level in 1.8
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.NetworkPolicySpec#policyTypes
        /// </remarks>
        [JsiiProperty(name: "policyTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? PolicyTypes
        {
            get
            {
                return null;
            }
        }

        /// <summary>NetworkPolicySpec provides the specification of a NetworkPolicy.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.NetworkPolicySpec
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(INetworkPolicySpec), fullyQualifiedName: "k8s.NetworkPolicySpec")]
        internal sealed class _Proxy : DeputyBase, K8s.INetworkPolicySpec
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>podSelector selects the pods to which this NetworkPolicy object applies.</summary>
            /// <remarks>
            /// The array of ingress rules is applied to any pods selected by this field. Multiple network policies can select the same set of pods. In this case, the ingress rules for each are combined additively. This field is NOT optional and follows standard label selector semantics. An empty podSelector matches all pods in this namespace.
            ///
            /// <strong>Schema</strong>: io.k8s.api.networking.v1.NetworkPolicySpec#podSelector
            /// </remarks>
            [JsiiProperty(name: "podSelector", typeJson: "{\"fqn\":\"k8s.LabelSelector\"}")]
            public K8s.ILabelSelector PodSelector
            {
                get => GetInstanceProperty<K8s.ILabelSelector>()!;
            }

            /// <summary>egress is a list of egress rules to be applied to the selected pods.</summary>
            /// <remarks>
            /// Outgoing traffic is allowed if there are no NetworkPolicies selecting the pod (and cluster policy otherwise allows the traffic), OR if the traffic matches at least one egress rule across all of the NetworkPolicy objects whose podSelector matches the pod. If this field is empty then this NetworkPolicy limits all outgoing traffic (and serves solely to ensure that the pods it selects are isolated by default). This field is beta-level in 1.8
            ///
            /// <strong>Schema</strong>: io.k8s.api.networking.v1.NetworkPolicySpec#egress
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "egress", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.NetworkPolicyEgressRule\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.INetworkPolicyEgressRule[]? Egress
            {
                get => GetInstanceProperty<K8s.INetworkPolicyEgressRule[]?>();
            }

            /// <summary>ingress is a list of ingress rules to be applied to the selected pods.</summary>
            /// <remarks>
            /// Traffic is allowed to a pod if there are no NetworkPolicies selecting the pod (and cluster policy otherwise allows the traffic), OR if the traffic source is the pod's local node, OR if the traffic matches at least one ingress rule across all of the NetworkPolicy objects whose podSelector matches the pod. If this field is empty then this NetworkPolicy does not allow any traffic (and serves solely to ensure that the pods it selects are isolated by default)
            ///
            /// <strong>Schema</strong>: io.k8s.api.networking.v1.NetworkPolicySpec#ingress
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ingress", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.NetworkPolicyIngressRule\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.INetworkPolicyIngressRule[]? Ingress
            {
                get => GetInstanceProperty<K8s.INetworkPolicyIngressRule[]?>();
            }

            /// <summary>policyTypes is a list of rule types that the NetworkPolicy relates to.</summary>
            /// <remarks>
            /// Valid options are ["Ingress"], ["Egress"], or ["Ingress", "Egress"]. If this field is not specified, it will default based on the existence of ingress or egress rules; policies that contain an egress section are assumed to affect egress, and all policies (whether or not they contain an ingress section) are assumed to affect ingress. If you want to write an egress-only policy, you must explicitly specify policyTypes [ "Egress" ]. Likewise, if you want to write a policy that specifies that no egress is allowed, you must specify a policyTypes value that include "Egress" (since such a policy would not include an egress section and would otherwise default to just [ "Ingress" ]). This field is beta-level in 1.8
            ///
            /// <strong>Schema</strong>: io.k8s.api.networking.v1.NetworkPolicySpec#policyTypes
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "policyTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? PolicyTypes
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
