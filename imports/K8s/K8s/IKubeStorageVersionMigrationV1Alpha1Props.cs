using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>StorageVersionMigration represents a migration of stored data to the latest storage version.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.storagemigration.v1alpha1.StorageVersionMigration
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeStorageVersionMigrationV1Alpha1Props), fullyQualifiedName: "k8s.KubeStorageVersionMigrationV1Alpha1Props")]
    public interface IKubeStorageVersionMigrationV1Alpha1Props
    {
        /// <summary>Standard object metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.storagemigration.v1alpha1.StorageVersionMigration#metadata
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

        /// <summary>Specification of the migration.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storagemigration.v1alpha1.StorageVersionMigration#spec
        /// </remarks>
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.StorageVersionMigrationSpecV1Alpha1\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IStorageVersionMigrationSpecV1Alpha1? Spec
        {
            get
            {
                return null;
            }
        }

        /// <summary>StorageVersionMigration represents a migration of stored data to the latest storage version.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storagemigration.v1alpha1.StorageVersionMigration
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeStorageVersionMigrationV1Alpha1Props), fullyQualifiedName: "k8s.KubeStorageVersionMigrationV1Alpha1Props")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeStorageVersionMigrationV1Alpha1Props
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

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
                get => GetInstanceProperty<K8s.IObjectMeta?>();
            }

            /// <summary>Specification of the migration.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.storagemigration.v1alpha1.StorageVersionMigration#spec
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.StorageVersionMigrationSpecV1Alpha1\"}", isOptional: true)]
            public K8s.IStorageVersionMigrationSpecV1Alpha1? Spec
            {
                get => GetInstanceProperty<K8s.IStorageVersionMigrationSpecV1Alpha1?>();
            }
        }
    }
}
