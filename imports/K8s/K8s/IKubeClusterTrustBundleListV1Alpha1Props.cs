using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ClusterTrustBundleList is a collection of ClusterTrustBundle objects.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.certificates.v1alpha1.ClusterTrustBundleList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeClusterTrustBundleListV1Alpha1Props), fullyQualifiedName: "k8s.KubeClusterTrustBundleListV1Alpha1Props")]
    public interface IKubeClusterTrustBundleListV1Alpha1Props
    {
        /// <summary>items is a collection of ClusterTrustBundle objects.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.certificates.v1alpha1.ClusterTrustBundleList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeClusterTrustBundleV1Alpha1Props\"},\"kind\":\"array\"}}")]
        K8s.IKubeClusterTrustBundleV1Alpha1Props[] Items
        {
            get;
        }

        /// <summary>metadata contains the list metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.certificates.v1alpha1.ClusterTrustBundleList#metadata
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

        /// <summary>ClusterTrustBundleList is a collection of ClusterTrustBundle objects.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.certificates.v1alpha1.ClusterTrustBundleList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeClusterTrustBundleListV1Alpha1Props), fullyQualifiedName: "k8s.KubeClusterTrustBundleListV1Alpha1Props")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeClusterTrustBundleListV1Alpha1Props
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>items is a collection of ClusterTrustBundle objects.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.certificates.v1alpha1.ClusterTrustBundleList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeClusterTrustBundleV1Alpha1Props\"},\"kind\":\"array\"}}")]
            public K8s.IKubeClusterTrustBundleV1Alpha1Props[] Items
            {
                get => GetInstanceProperty<K8s.IKubeClusterTrustBundleV1Alpha1Props[]>()!;
            }

            /// <summary>metadata contains the list metadata.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.certificates.v1alpha1.ClusterTrustBundleList#metadata
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
