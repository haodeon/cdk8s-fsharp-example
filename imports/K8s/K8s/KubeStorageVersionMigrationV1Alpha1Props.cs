using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>StorageVersionMigration represents a migration of stored data to the latest storage version.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.storagemigration.v1alpha1.StorageVersionMigration
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeStorageVersionMigrationV1Alpha1Props")]
    public class KubeStorageVersionMigrationV1Alpha1Props : K8s.IKubeStorageVersionMigrationV1Alpha1Props
    {
        /// <summary>Standard object metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.storagemigration.v1alpha1.StorageVersionMigration#metadata
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        public K8s.IObjectMeta? Metadata
        {
            get;
            set;
        }

        /// <summary>Specification of the migration.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storagemigration.v1alpha1.StorageVersionMigration#spec
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.StorageVersionMigrationSpecV1Alpha1\"}", isOptional: true)]
        public K8s.IStorageVersionMigrationSpecV1Alpha1? Spec
        {
            get;
            set;
        }
    }
}
