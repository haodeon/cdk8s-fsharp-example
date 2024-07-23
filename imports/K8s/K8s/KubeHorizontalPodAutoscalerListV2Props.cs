using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>HorizontalPodAutoscalerList is a list of horizontal pod autoscaler objects.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.HorizontalPodAutoscalerList
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeHorizontalPodAutoscalerListV2Props")]
    public class KubeHorizontalPodAutoscalerListV2Props : K8s.IKubeHorizontalPodAutoscalerListV2Props
    {
        /// <summary>items is the list of horizontal pod autoscaler objects.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.HorizontalPodAutoscalerList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeHorizontalPodAutoscalerV2Props\"},\"kind\":\"array\"}}")]
        public K8s.IKubeHorizontalPodAutoscalerV2Props[] Items
        {
            get;
            set;
        }

        /// <summary>metadata is the standard list metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.HorizontalPodAutoscalerList#metadata
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
