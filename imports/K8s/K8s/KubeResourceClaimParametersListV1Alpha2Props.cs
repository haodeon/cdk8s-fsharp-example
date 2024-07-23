using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>ResourceClaimParametersList is a collection of ResourceClaimParameters.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaimParametersList
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeResourceClaimParametersListV1Alpha2Props")]
    public class KubeResourceClaimParametersListV1Alpha2Props : K8s.IKubeResourceClaimParametersListV1Alpha2Props
    {
        /// <summary>Items is the list of node resource capacity objects.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaimParametersList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeResourceClaimParametersV1Alpha2Props\"},\"kind\":\"array\"}}")]
        public K8s.IKubeResourceClaimParametersV1Alpha2Props[] Items
        {
            get;
            set;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaimParametersList#metadata
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
