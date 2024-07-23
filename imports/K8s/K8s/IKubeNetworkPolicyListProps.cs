using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>NetworkPolicyList is a list of NetworkPolicy objects.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.networking.v1.NetworkPolicyList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeNetworkPolicyListProps), fullyQualifiedName: "k8s.KubeNetworkPolicyListProps")]
    public interface IKubeNetworkPolicyListProps
    {
        /// <summary>items is a list of schema objects.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.NetworkPolicyList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeNetworkPolicyProps\"},\"kind\":\"array\"}}")]
        K8s.IKubeNetworkPolicyProps[] Items
        {
            get;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.NetworkPolicyList#metadata
        /// </remarks>
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ListMeta\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IListMeta? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>NetworkPolicyList is a list of NetworkPolicy objects.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.NetworkPolicyList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeNetworkPolicyListProps), fullyQualifiedName: "k8s.KubeNetworkPolicyListProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeNetworkPolicyListProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>items is a list of schema objects.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.networking.v1.NetworkPolicyList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeNetworkPolicyProps\"},\"kind\":\"array\"}}")]
            public K8s.IKubeNetworkPolicyProps[] Items
            {
                get => GetInstanceProperty<K8s.IKubeNetworkPolicyProps[]>()!;
            }

            /// <summary>Standard list metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
            ///
            /// <strong>Schema</strong>: io.k8s.api.networking.v1.NetworkPolicyList#metadata
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ListMeta\"}", isOptional: true)]
            public K8s.IListMeta? Metadata
            {
                get => GetInstanceProperty<K8s.IListMeta?>();
            }
        }
    }
}
