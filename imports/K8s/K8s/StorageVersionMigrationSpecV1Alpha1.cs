using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>Spec of the storage version migration.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.storagemigration.v1alpha1.StorageVersionMigrationSpec
    /// </remarks>
    [JsiiByValue(fqn: "k8s.StorageVersionMigrationSpecV1Alpha1")]
    public class StorageVersionMigrationSpecV1Alpha1 : K8s.IStorageVersionMigrationSpecV1Alpha1
    {
        /// <summary>The resource that is being migrated.</summary>
        /// <remarks>
        /// The migrator sends requests to the endpoint serving the resource. Immutable.
        ///
        /// <strong>Schema</strong>: io.k8s.api.storagemigration.v1alpha1.StorageVersionMigrationSpec#resource
        /// </remarks>
        [JsiiProperty(name: "resource", typeJson: "{\"fqn\":\"k8s.GroupVersionResourceV1Alpha1\"}")]
        public K8s.IGroupVersionResourceV1Alpha1 Resource
        {
            get;
            set;
        }

        /// <summary>The token used in the list options to get the next chunk of objects to migrate.</summary>
        /// <remarks>
        /// When the .status.conditions indicates the migration is "Running", users can use this token to check the progress of the migration.
        ///
        /// <strong>Schema</strong>: io.k8s.api.storagemigration.v1alpha1.StorageVersionMigrationSpec#continueToken
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "continueToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ContinueToken
        {
            get;
            set;
        }
    }
}
