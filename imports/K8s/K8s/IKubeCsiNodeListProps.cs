using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>CSINodeList is a collection of CSINode objects.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSINodeList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeCsiNodeListProps), fullyQualifiedName: "k8s.KubeCsiNodeListProps")]
    public interface IKubeCsiNodeListProps
    {
        /// <summary>items is the list of CSINode.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSINodeList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeCsiNodeProps\"},\"kind\":\"array\"}}")]
        K8s.IKubeCsiNodeProps[] Items
        {
            get;
        }

        /// <summary>Standard list metadata More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSINodeList#metadata
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

        /// <summary>CSINodeList is a collection of CSINode objects.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSINodeList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeCsiNodeListProps), fullyQualifiedName: "k8s.KubeCsiNodeListProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeCsiNodeListProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>items is the list of CSINode.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSINodeList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeCsiNodeProps\"},\"kind\":\"array\"}}")]
            public K8s.IKubeCsiNodeProps[] Items
            {
                get => GetInstanceProperty<K8s.IKubeCsiNodeProps[]>()!;
            }

            /// <summary>Standard list metadata More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSINodeList#metadata
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
