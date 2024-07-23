using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>PodSchedulingContextList is a collection of Pod scheduling objects.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.PodSchedulingContextList
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubePodSchedulingContextListV1Alpha2Props")]
    public class KubePodSchedulingContextListV1Alpha2Props : K8s.IKubePodSchedulingContextListV1Alpha2Props
    {
        /// <summary>Items is the list of PodSchedulingContext objects.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.PodSchedulingContextList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubePodSchedulingContextV1Alpha2Props\"},\"kind\":\"array\"}}")]
        public K8s.IKubePodSchedulingContextV1Alpha2Props[] Items
        {
            get;
            set;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.PodSchedulingContextList#metadata
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
