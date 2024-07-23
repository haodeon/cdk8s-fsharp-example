using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ConfigMapList is a resource containing a list of ConfigMap objects.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMapList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeConfigMapListProps), fullyQualifiedName: "k8s.KubeConfigMapListProps")]
    public interface IKubeConfigMapListProps
    {
        /// <summary>Items is the list of ConfigMaps.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMapList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeConfigMapProps\"},\"kind\":\"array\"}}")]
        K8s.IKubeConfigMapProps[] Items
        {
            get;
        }

        /// <summary>More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMapList#metadata
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

        /// <summary>ConfigMapList is a resource containing a list of ConfigMap objects.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMapList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeConfigMapListProps), fullyQualifiedName: "k8s.KubeConfigMapListProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeConfigMapListProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Items is the list of ConfigMaps.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMapList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeConfigMapProps\"},\"kind\":\"array\"}}")]
            public K8s.IKubeConfigMapProps[] Items
            {
                get => GetInstanceProperty<K8s.IKubeConfigMapProps[]>()!;
            }

            /// <summary>More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMapList#metadata
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
