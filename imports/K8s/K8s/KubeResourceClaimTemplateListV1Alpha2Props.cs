using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>ResourceClaimTemplateList is a collection of claim templates.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaimTemplateList
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeResourceClaimTemplateListV1Alpha2Props")]
    public class KubeResourceClaimTemplateListV1Alpha2Props : K8s.IKubeResourceClaimTemplateListV1Alpha2Props
    {
        /// <summary>Items is the list of resource claim templates.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaimTemplateList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeResourceClaimTemplateV1Alpha2Props\"},\"kind\":\"array\"}}")]
        public K8s.IKubeResourceClaimTemplateV1Alpha2Props[] Items
        {
            get;
            set;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaimTemplateList#metadata
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
