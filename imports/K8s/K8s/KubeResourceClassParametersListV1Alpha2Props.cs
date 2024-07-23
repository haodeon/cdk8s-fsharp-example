using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>ResourceClassParametersList is a collection of ResourceClassParameters.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClassParametersList
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeResourceClassParametersListV1Alpha2Props")]
    public class KubeResourceClassParametersListV1Alpha2Props : K8s.IKubeResourceClassParametersListV1Alpha2Props
    {
        /// <summary>Items is the list of node resource capacity objects.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClassParametersList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeResourceClassParametersV1Alpha2Props\"},\"kind\":\"array\"}}")]
        public K8s.IKubeResourceClassParametersV1Alpha2Props[] Items
        {
            get;
            set;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClassParametersList#metadata
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
