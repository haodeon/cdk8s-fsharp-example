using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>StorageClassList is a collection of storage classes.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.storage.v1.StorageClassList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeStorageClassListProps), fullyQualifiedName: "k8s.KubeStorageClassListProps")]
    public interface IKubeStorageClassListProps
    {
        /// <summary>items is the list of StorageClasses.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.StorageClassList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeStorageClassProps\"},\"kind\":\"array\"}}")]
        K8s.IKubeStorageClassProps[] Items
        {
            get;
        }

        /// <summary>Standard list metadata More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.StorageClassList#metadata
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

        /// <summary>StorageClassList is a collection of storage classes.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.StorageClassList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeStorageClassListProps), fullyQualifiedName: "k8s.KubeStorageClassListProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeStorageClassListProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>items is the list of StorageClasses.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.storage.v1.StorageClassList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeStorageClassProps\"},\"kind\":\"array\"}}")]
            public K8s.IKubeStorageClassProps[] Items
            {
                get => GetInstanceProperty<K8s.IKubeStorageClassProps[]>()!;
            }

            /// <summary>Standard list metadata More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.storage.v1.StorageClassList#metadata
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
