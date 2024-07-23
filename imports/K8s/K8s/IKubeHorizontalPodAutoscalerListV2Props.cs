using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>HorizontalPodAutoscalerList is a list of horizontal pod autoscaler objects.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.HorizontalPodAutoscalerList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeHorizontalPodAutoscalerListV2Props), fullyQualifiedName: "k8s.KubeHorizontalPodAutoscalerListV2Props")]
    public interface IKubeHorizontalPodAutoscalerListV2Props
    {
        /// <summary>items is the list of horizontal pod autoscaler objects.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.HorizontalPodAutoscalerList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeHorizontalPodAutoscalerV2Props\"},\"kind\":\"array\"}}")]
        K8s.IKubeHorizontalPodAutoscalerV2Props[] Items
        {
            get;
        }

        /// <summary>metadata is the standard list metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.HorizontalPodAutoscalerList#metadata
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

        /// <summary>HorizontalPodAutoscalerList is a list of horizontal pod autoscaler objects.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.HorizontalPodAutoscalerList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeHorizontalPodAutoscalerListV2Props), fullyQualifiedName: "k8s.KubeHorizontalPodAutoscalerListV2Props")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeHorizontalPodAutoscalerListV2Props
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>items is the list of horizontal pod autoscaler objects.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.HorizontalPodAutoscalerList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeHorizontalPodAutoscalerV2Props\"},\"kind\":\"array\"}}")]
            public K8s.IKubeHorizontalPodAutoscalerV2Props[] Items
            {
                get => GetInstanceProperty<K8s.IKubeHorizontalPodAutoscalerV2Props[]>()!;
            }

            /// <summary>metadata is the standard list metadata.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.HorizontalPodAutoscalerList#metadata
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
