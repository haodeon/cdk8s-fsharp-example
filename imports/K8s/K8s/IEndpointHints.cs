using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>EndpointHints provides hints describing how an endpoint should be consumed.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.discovery.v1.EndpointHints
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IEndpointHints), fullyQualifiedName: "k8s.EndpointHints")]
    public interface IEndpointHints
    {
        /// <summary>forZones indicates the zone(s) this endpoint should be consumed by to enable topology aware routing.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.discovery.v1.EndpointHints#forZones
        /// </remarks>
        [JsiiProperty(name: "forZones", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.ForZone\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IForZone[]? ForZones
        {
            get
            {
                return null;
            }
        }

        /// <summary>EndpointHints provides hints describing how an endpoint should be consumed.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.discovery.v1.EndpointHints
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IEndpointHints), fullyQualifiedName: "k8s.EndpointHints")]
        internal sealed class _Proxy : DeputyBase, K8s.IEndpointHints
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>forZones indicates the zone(s) this endpoint should be consumed by to enable topology aware routing.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.discovery.v1.EndpointHints#forZones
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forZones", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.ForZone\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.IForZone[]? ForZones
            {
                get => GetInstanceProperty<K8s.IForZone[]?>();
            }
        }
    }
}
