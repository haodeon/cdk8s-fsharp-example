using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>IngressClassList is a collection of IngressClasses.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressClassList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeIngressClassListProps), fullyQualifiedName: "k8s.KubeIngressClassListProps")]
    public interface IKubeIngressClassListProps
    {
        /// <summary>items is the list of IngressClasses.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressClassList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeIngressClassProps\"},\"kind\":\"array\"}}")]
        K8s.IKubeIngressClassProps[] Items
        {
            get;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressClassList#metadata
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

        /// <summary>IngressClassList is a collection of IngressClasses.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressClassList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeIngressClassListProps), fullyQualifiedName: "k8s.KubeIngressClassListProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeIngressClassListProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>items is the list of IngressClasses.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressClassList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeIngressClassProps\"},\"kind\":\"array\"}}")]
            public K8s.IKubeIngressClassProps[] Items
            {
                get => GetInstanceProperty<K8s.IKubeIngressClassProps[]>()!;
            }

            /// <summary>Standard list metadata.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressClassList#metadata
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
