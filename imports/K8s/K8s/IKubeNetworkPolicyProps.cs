using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>NetworkPolicy describes what network traffic is allowed for a set of Pods.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.networking.v1.NetworkPolicy
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeNetworkPolicyProps), fullyQualifiedName: "k8s.KubeNetworkPolicyProps")]
    public interface IKubeNetworkPolicyProps
    {
        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.NetworkPolicy#metadata
        /// </remarks>
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IObjectMeta? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>spec represents the specification of the desired behavior for this NetworkPolicy.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.NetworkPolicy#spec
        /// </remarks>
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.NetworkPolicySpec\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.INetworkPolicySpec? Spec
        {
            get
            {
                return null;
            }
        }

        /// <summary>NetworkPolicy describes what network traffic is allowed for a set of Pods.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.NetworkPolicy
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeNetworkPolicyProps), fullyQualifiedName: "k8s.KubeNetworkPolicyProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeNetworkPolicyProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Standard object's metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
            ///
            /// <strong>Schema</strong>: io.k8s.api.networking.v1.NetworkPolicy#metadata
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
            public K8s.IObjectMeta? Metadata
            {
                get => GetInstanceProperty<K8s.IObjectMeta?>();
            }

            /// <summary>spec represents the specification of the desired behavior for this NetworkPolicy.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.networking.v1.NetworkPolicy#spec
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.NetworkPolicySpec\"}", isOptional: true)]
            public K8s.INetworkPolicySpec? Spec
            {
                get => GetInstanceProperty<K8s.INetworkPolicySpec?>();
            }
        }
    }
}
