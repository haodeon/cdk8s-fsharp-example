using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>CSIDriverList is a collection of CSIDriver objects.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSIDriverList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeCsiDriverListProps), fullyQualifiedName: "k8s.KubeCsiDriverListProps")]
    public interface IKubeCsiDriverListProps
    {
        /// <summary>items is the list of CSIDriver.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSIDriverList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeCsiDriverProps\"},\"kind\":\"array\"}}")]
        K8s.IKubeCsiDriverProps[] Items
        {
            get;
        }

        /// <summary>Standard list metadata More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSIDriverList#metadata
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

        /// <summary>CSIDriverList is a collection of CSIDriver objects.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSIDriverList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeCsiDriverListProps), fullyQualifiedName: "k8s.KubeCsiDriverListProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeCsiDriverListProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>items is the list of CSIDriver.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSIDriverList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeCsiDriverProps\"},\"kind\":\"array\"}}")]
            public K8s.IKubeCsiDriverProps[] Items
            {
                get => GetInstanceProperty<K8s.IKubeCsiDriverProps[]>()!;
            }

            /// <summary>Standard list metadata More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSIDriverList#metadata
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
