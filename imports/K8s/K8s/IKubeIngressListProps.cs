using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>IngressList is a collection of Ingress.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeIngressListProps), fullyQualifiedName: "k8s.KubeIngressListProps")]
    public interface IKubeIngressListProps
    {
        /// <summary>items is the list of Ingress.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeIngressProps\"},\"kind\":\"array\"}}")]
        K8s.IKubeIngressProps[] Items
        {
            get;
        }

        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressList#metadata
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

        /// <summary>IngressList is a collection of Ingress.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeIngressListProps), fullyQualifiedName: "k8s.KubeIngressListProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeIngressListProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>items is the list of Ingress.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeIngressProps\"},\"kind\":\"array\"}}")]
            public K8s.IKubeIngressProps[] Items
            {
                get => GetInstanceProperty<K8s.IKubeIngressProps[]>()!;
            }

            /// <summary>Standard object's metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
            ///
            /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressList#metadata
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
