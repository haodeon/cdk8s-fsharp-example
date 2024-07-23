using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>EndpointHints provides hints describing how an endpoint should be consumed.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.discovery.v1.EndpointHints
    /// </remarks>
    [JsiiByValue(fqn: "k8s.EndpointHints")]
    public class EndpointHints : K8s.IEndpointHints
    {
        /// <summary>forZones indicates the zone(s) this endpoint should be consumed by to enable topology aware routing.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.discovery.v1.EndpointHints#forZones
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forZones", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.ForZone\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.IForZone[]? ForZones
        {
            get;
            set;
        }
    }
}
