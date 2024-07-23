using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>PersistentVolumeClaimList is a list of PersistentVolumeClaim items.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeClaimList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubePersistentVolumeClaimListProps), fullyQualifiedName: "k8s.KubePersistentVolumeClaimListProps")]
    public interface IKubePersistentVolumeClaimListProps
    {
        /// <summary>items is a list of persistent volume claims.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#persistentvolumeclaims
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeClaimList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubePersistentVolumeClaimProps\"},\"kind\":\"array\"}}")]
        K8s.IKubePersistentVolumeClaimProps[] Items
        {
            get;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeClaimList#metadata
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

        /// <summary>PersistentVolumeClaimList is a list of PersistentVolumeClaim items.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeClaimList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubePersistentVolumeClaimListProps), fullyQualifiedName: "k8s.KubePersistentVolumeClaimListProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubePersistentVolumeClaimListProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>items is a list of persistent volume claims.</summary>
            /// <remarks>
            /// More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#persistentvolumeclaims
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeClaimList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubePersistentVolumeClaimProps\"},\"kind\":\"array\"}}")]
            public K8s.IKubePersistentVolumeClaimProps[] Items
            {
                get => GetInstanceProperty<K8s.IKubePersistentVolumeClaimProps[]>()!;
            }

            /// <summary>Standard list metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeClaimList#metadata
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
