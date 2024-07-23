using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>list of horizontal pod autoscaler objects.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.autoscaling.v1.HorizontalPodAutoscalerList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeHorizontalPodAutoscalerListProps), fullyQualifiedName: "k8s.KubeHorizontalPodAutoscalerListProps")]
    public interface IKubeHorizontalPodAutoscalerListProps
    {
        /// <summary>items is the list of horizontal pod autoscaler objects.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v1.HorizontalPodAutoscalerList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeHorizontalPodAutoscalerProps\"},\"kind\":\"array\"}}")]
        K8s.IKubeHorizontalPodAutoscalerProps[] Items
        {
            get;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v1.HorizontalPodAutoscalerList#metadata
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

        /// <summary>list of horizontal pod autoscaler objects.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v1.HorizontalPodAutoscalerList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeHorizontalPodAutoscalerListProps), fullyQualifiedName: "k8s.KubeHorizontalPodAutoscalerListProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeHorizontalPodAutoscalerListProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>items is the list of horizontal pod autoscaler objects.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.autoscaling.v1.HorizontalPodAutoscalerList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeHorizontalPodAutoscalerProps\"},\"kind\":\"array\"}}")]
            public K8s.IKubeHorizontalPodAutoscalerProps[] Items
            {
                get => GetInstanceProperty<K8s.IKubeHorizontalPodAutoscalerProps[]>()!;
            }

            /// <summary>Standard list metadata.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.autoscaling.v1.HorizontalPodAutoscalerList#metadata
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
