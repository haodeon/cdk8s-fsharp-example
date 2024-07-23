using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>NamespaceList is a list of Namespaces.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.NamespaceList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeNamespaceListProps), fullyQualifiedName: "k8s.KubeNamespaceListProps")]
    public interface IKubeNamespaceListProps
    {
        /// <summary>Items is the list of Namespace objects in the list.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.NamespaceList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeNamespaceProps\"},\"kind\":\"array\"}}")]
        K8s.IKubeNamespaceProps[] Items
        {
            get;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.NamespaceList#metadata
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

        /// <summary>NamespaceList is a list of Namespaces.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.NamespaceList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeNamespaceListProps), fullyQualifiedName: "k8s.KubeNamespaceListProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeNamespaceListProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Items is the list of Namespace objects in the list.</summary>
            /// <remarks>
            /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.NamespaceList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeNamespaceProps\"},\"kind\":\"array\"}}")]
            public K8s.IKubeNamespaceProps[] Items
            {
                get => GetInstanceProperty<K8s.IKubeNamespaceProps[]>()!;
            }

            /// <summary>Standard list metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.NamespaceList#metadata
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
