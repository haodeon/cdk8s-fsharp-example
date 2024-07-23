using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>StorageVersionMigrationList is a collection of storage version migrations.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.storagemigration.v1alpha1.StorageVersionMigrationList
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeStorageVersionMigrationListV1Alpha1Props")]
    public class KubeStorageVersionMigrationListV1Alpha1Props : K8s.IKubeStorageVersionMigrationListV1Alpha1Props
    {
        /// <summary>Items is the list of StorageVersionMigration.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storagemigration.v1alpha1.StorageVersionMigrationList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeStorageVersionMigrationV1Alpha1Props\"},\"kind\":\"array\"}}")]
        public K8s.IKubeStorageVersionMigrationV1Alpha1Props[] Items
        {
            get;
            set;
        }

        /// <summary>Standard list metadata More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storagemigration.v1alpha1.StorageVersionMigrationList#metadata
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ListMeta\"}", isOptional: true)]
        public K8s.IListMeta? Metadata
        {
            get;
            set;
        }
    }
}
