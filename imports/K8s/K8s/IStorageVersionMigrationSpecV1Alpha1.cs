using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Spec of the storage version migration.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.storagemigration.v1alpha1.StorageVersionMigrationSpec
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IStorageVersionMigrationSpecV1Alpha1), fullyQualifiedName: "k8s.StorageVersionMigrationSpecV1Alpha1")]
    public interface IStorageVersionMigrationSpecV1Alpha1
    {
        /// <summary>The resource that is being migrated.</summary>
        /// <remarks>
        /// The migrator sends requests to the endpoint serving the resource. Immutable.
        ///
        /// <strong>Schema</strong>: io.k8s.api.storagemigration.v1alpha1.StorageVersionMigrationSpec#resource
        /// </remarks>
        [JsiiProperty(name: "resource", typeJson: "{\"fqn\":\"k8s.GroupVersionResourceV1Alpha1\"}")]
        K8s.IGroupVersionResourceV1Alpha1 Resource
        {
            get;
        }

        /// <summary>The token used in the list options to get the next chunk of objects to migrate.</summary>
        /// <remarks>
        /// When the .status.conditions indicates the migration is "Running", users can use this token to check the progress of the migration.
        ///
        /// <strong>Schema</strong>: io.k8s.api.storagemigration.v1alpha1.StorageVersionMigrationSpec#continueToken
        /// </remarks>
        [JsiiProperty(name: "continueToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ContinueToken
        {
            get
            {
                return null;
            }
        }

        /// <summary>Spec of the storage version migration.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storagemigration.v1alpha1.StorageVersionMigrationSpec
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IStorageVersionMigrationSpecV1Alpha1), fullyQualifiedName: "k8s.StorageVersionMigrationSpecV1Alpha1")]
        internal sealed class _Proxy : DeputyBase, K8s.IStorageVersionMigrationSpecV1Alpha1
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The resource that is being migrated.</summary>
            /// <remarks>
            /// The migrator sends requests to the endpoint serving the resource. Immutable.
            ///
            /// <strong>Schema</strong>: io.k8s.api.storagemigration.v1alpha1.StorageVersionMigrationSpec#resource
            /// </remarks>
            [JsiiProperty(name: "resource", typeJson: "{\"fqn\":\"k8s.GroupVersionResourceV1Alpha1\"}")]
            public K8s.IGroupVersionResourceV1Alpha1 Resource
            {
                get => GetInstanceProperty<K8s.IGroupVersionResourceV1Alpha1>()!;
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
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
