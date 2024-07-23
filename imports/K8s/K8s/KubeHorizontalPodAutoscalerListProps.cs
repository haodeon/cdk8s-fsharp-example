using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>list of horizontal pod autoscaler objects.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.autoscaling.v1.HorizontalPodAutoscalerList
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeHorizontalPodAutoscalerListProps")]
    public class KubeHorizontalPodAutoscalerListProps : K8s.IKubeHorizontalPodAutoscalerListProps
    {
        /// <summary>items is the list of horizontal pod autoscaler objects.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v1.HorizontalPodAutoscalerList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeHorizontalPodAutoscalerProps\"},\"kind\":\"array\"}}")]
        public K8s.IKubeHorizontalPodAutoscalerProps[] Items
        {
            get;
            set;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v1.HorizontalPodAutoscalerList#metadata
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
