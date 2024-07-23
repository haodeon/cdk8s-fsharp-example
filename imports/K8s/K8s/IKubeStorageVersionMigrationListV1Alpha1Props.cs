using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>StorageVersionMigrationList is a collection of storage version migrations.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.storagemigration.v1alpha1.StorageVersionMigrationList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeStorageVersionMigrationListV1Alpha1Props), fullyQualifiedName: "k8s.KubeStorageVersionMigrationListV1Alpha1Props")]
    public interface IKubeStorageVersionMigrationListV1Alpha1Props
    {
        /// <summary>Items is the list of StorageVersionMigration.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storagemigration.v1alpha1.StorageVersionMigrationList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeStorageVersionMigrationV1Alpha1Props\"},\"kind\":\"array\"}}")]
        K8s.IKubeStorageVersionMigrationV1Alpha1Props[] Items
        {
            get;
        }

        /// <summary>Standard list metadata More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storagemigration.v1alpha1.StorageVersionMigrationList#metadata
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

        /// <summary>StorageVersionMigrationList is a collection of storage version migrations.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storagemigration.v1alpha1.StorageVersionMigrationList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeStorageVersionMigrationListV1Alpha1Props), fullyQualifiedName: "k8s.KubeStorageVersionMigrationListV1Alpha1Props")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeStorageVersionMigrationListV1Alpha1Props
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Items is the list of StorageVersionMigration.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.storagemigration.v1alpha1.StorageVersionMigrationList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeStorageVersionMigrationV1Alpha1Props\"},\"kind\":\"array\"}}")]
            public K8s.IKubeStorageVersionMigrationV1Alpha1Props[] Items
            {
                get => GetInstanceProperty<K8s.IKubeStorageVersionMigrationV1Alpha1Props[]>()!;
            }

            /// <summary>Standard list metadata More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.storagemigration.v1alpha1.StorageVersionMigrationList#metadata
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
