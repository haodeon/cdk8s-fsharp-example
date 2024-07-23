using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ServiceList holds a list of services.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeServiceListProps), fullyQualifiedName: "k8s.KubeServiceListProps")]
    public interface IKubeServiceListProps
    {
        /// <summary>List of services.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeServiceProps\"},\"kind\":\"array\"}}")]
        K8s.IKubeServiceProps[] Items
        {
            get;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceList#metadata
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

        /// <summary>ServiceList holds a list of services.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeServiceListProps), fullyQualifiedName: "k8s.KubeServiceListProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeServiceListProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>List of services.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeServiceProps\"},\"kind\":\"array\"}}")]
            public K8s.IKubeServiceProps[] Items
            {
                get => GetInstanceProperty<K8s.IKubeServiceProps[]>()!;
            }

            /// <summary>Standard list metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceList#metadata
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
