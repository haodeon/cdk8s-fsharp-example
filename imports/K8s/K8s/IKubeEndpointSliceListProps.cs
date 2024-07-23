using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>EndpointSliceList represents a list of endpoint slices.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.discovery.v1.EndpointSliceList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeEndpointSliceListProps), fullyQualifiedName: "k8s.KubeEndpointSliceListProps")]
    public interface IKubeEndpointSliceListProps
    {
        /// <summary>items is the list of endpoint slices.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.discovery.v1.EndpointSliceList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeEndpointSliceProps\"},\"kind\":\"array\"}}")]
        K8s.IKubeEndpointSliceProps[] Items
        {
            get;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.discovery.v1.EndpointSliceList#metadata
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

        /// <summary>EndpointSliceList represents a list of endpoint slices.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.discovery.v1.EndpointSliceList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeEndpointSliceListProps), fullyQualifiedName: "k8s.KubeEndpointSliceListProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeEndpointSliceListProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>items is the list of endpoint slices.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.discovery.v1.EndpointSliceList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeEndpointSliceProps\"},\"kind\":\"array\"}}")]
            public K8s.IKubeEndpointSliceProps[] Items
            {
                get => GetInstanceProperty<K8s.IKubeEndpointSliceProps[]>()!;
            }

            /// <summary>Standard list metadata.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.discovery.v1.EndpointSliceList#metadata
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
