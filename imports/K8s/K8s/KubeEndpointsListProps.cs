using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>EndpointsList is a list of endpoints.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.EndpointsList
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeEndpointsListProps")]
    public class KubeEndpointsListProps : K8s.IKubeEndpointsListProps
    {
        /// <summary>List of endpoints.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EndpointsList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeEndpointsProps\"},\"kind\":\"array\"}}")]
        public K8s.IKubeEndpointsProps[] Items
        {
            get;
            set;
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
            get;
            set;
        }
    }
}
