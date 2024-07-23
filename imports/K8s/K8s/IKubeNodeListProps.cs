using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>NodeList is the whole list of all Nodes which have been registered with master.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.NodeList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeNodeListProps), fullyQualifiedName: "k8s.KubeNodeListProps")]
    public interface IKubeNodeListProps
    {
        /// <summary>List of nodes.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.NodeList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeNodeProps\"},\"kind\":\"array\"}}")]
        K8s.IKubeNodeProps[] Items
        {
            get;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.NodeList#metadata
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

        /// <summary>NodeList is the whole list of all Nodes which have been registered with master.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.NodeList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeNodeListProps), fullyQualifiedName: "k8s.KubeNodeListProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeNodeListProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>List of nodes.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.NodeList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeNodeProps\"},\"kind\":\"array\"}}")]
            public K8s.IKubeNodeProps[] Items
            {
                get => GetInstanceProperty<K8s.IKubeNodeProps[]>()!;
            }

            /// <summary>Standard list metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.NodeList#metadata
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
