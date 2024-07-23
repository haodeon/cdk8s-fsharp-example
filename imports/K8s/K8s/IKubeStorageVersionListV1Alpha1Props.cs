using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>A list of StorageVersions.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.apiserverinternal.v1alpha1.StorageVersionList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeStorageVersionListV1Alpha1Props), fullyQualifiedName: "k8s.KubeStorageVersionListV1Alpha1Props")]
    public interface IKubeStorageVersionListV1Alpha1Props
    {
        /// <summary>Items holds a list of StorageVersion.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.apiserverinternal.v1alpha1.StorageVersionList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeStorageVersionV1Alpha1Props\"},\"kind\":\"array\"}}")]
        K8s.IKubeStorageVersionV1Alpha1Props[] Items
        {
            get;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.apiserverinternal.v1alpha1.StorageVersionList#metadata
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

        /// <summary>A list of StorageVersions.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.apiserverinternal.v1alpha1.StorageVersionList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeStorageVersionListV1Alpha1Props), fullyQualifiedName: "k8s.KubeStorageVersionListV1Alpha1Props")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeStorageVersionListV1Alpha1Props
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Items holds a list of StorageVersion.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.apiserverinternal.v1alpha1.StorageVersionList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeStorageVersionV1Alpha1Props\"},\"kind\":\"array\"}}")]
            public K8s.IKubeStorageVersionV1Alpha1Props[] Items
            {
                get => GetInstanceProperty<K8s.IKubeStorageVersionV1Alpha1Props[]>()!;
            }

            /// <summary>Standard list metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
            ///
            /// <strong>Schema</strong>: io.k8s.api.apiserverinternal.v1alpha1.StorageVersionList#metadata
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
