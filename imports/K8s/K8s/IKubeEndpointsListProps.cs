using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>EndpointsList is a list of endpoints.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.EndpointsList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeEndpointsListProps), fullyQualifiedName: "k8s.KubeEndpointsListProps")]
    public interface IKubeEndpointsListProps
    {
        /// <summary>List of endpoints.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EndpointsList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeEndpointsProps\"},\"kind\":\"array\"}}")]
        K8s.IKubeEndpointsProps[] Items
        {
            get;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EndpointsList#metadata
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

        /// <summary>EndpointsList is a list of endpoints.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EndpointsList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeEndpointsListProps), fullyQualifiedName: "k8s.KubeEndpointsListProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeEndpointsListProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>List of endpoints.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.EndpointsList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeEndpointsProps\"},\"kind\":\"array\"}}")]
            public K8s.IKubeEndpointsProps[] Items
            {
                get => GetInstanceProperty<K8s.IKubeEndpointsProps[]>()!;
            }

            /// <summary>Standard list metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.EndpointsList#metadata
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
