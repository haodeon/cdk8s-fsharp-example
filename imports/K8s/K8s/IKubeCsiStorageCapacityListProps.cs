using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>CSIStorageCapacityList is a collection of CSIStorageCapacity objects.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSIStorageCapacityList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeCsiStorageCapacityListProps), fullyQualifiedName: "k8s.KubeCsiStorageCapacityListProps")]
    public interface IKubeCsiStorageCapacityListProps
    {
        /// <summary>items is the list of CSIStorageCapacity objects.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSIStorageCapacityList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeCsiStorageCapacityProps\"},\"kind\":\"array\"}}")]
        K8s.IKubeCsiStorageCapacityProps[] Items
        {
            get;
        }

        /// <summary>Standard list metadata More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSIStorageCapacityList#metadata
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

        /// <summary>CSIStorageCapacityList is a collection of CSIStorageCapacity objects.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSIStorageCapacityList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeCsiStorageCapacityListProps), fullyQualifiedName: "k8s.KubeCsiStorageCapacityListProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeCsiStorageCapacityListProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>items is the list of CSIStorageCapacity objects.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSIStorageCapacityList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeCsiStorageCapacityProps\"},\"kind\":\"array\"}}")]
            public K8s.IKubeCsiStorageCapacityProps[] Items
            {
                get => GetInstanceProperty<K8s.IKubeCsiStorageCapacityProps[]>()!;
            }

            /// <summary>Standard list metadata More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSIStorageCapacityList#metadata
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
