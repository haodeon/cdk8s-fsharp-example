using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>HorizontalPodAutoscaler is the configuration for a horizontal pod autoscaler, which automatically manages the replica count of any resource implementing the scale subresource based on the metrics specified.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.HorizontalPodAutoscaler
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeHorizontalPodAutoscalerV2Props), fullyQualifiedName: "k8s.KubeHorizontalPodAutoscalerV2Props")]
    public interface IKubeHorizontalPodAutoscalerV2Props
    {
        /// <summary>metadata is the standard object metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.HorizontalPodAutoscaler#metadata
        /// </remarks>
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IObjectMeta? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>spec is the specification for the behaviour of the autoscaler.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status.
        ///
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.HorizontalPodAutoscaler#spec
        /// </remarks>
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.HorizontalPodAutoscalerSpecV2\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IHorizontalPodAutoscalerSpecV2? Spec
        {
            get
            {
                return null;
            }
        }

        /// <summary>HorizontalPodAutoscaler is the configuration for a horizontal pod autoscaler, which automatically manages the replica count of any resource implementing the scale subresource based on the metrics specified.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.HorizontalPodAutoscaler
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeHorizontalPodAutoscalerV2Props), fullyQualifiedName: "k8s.KubeHorizontalPodAutoscalerV2Props")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeHorizontalPodAutoscalerV2Props
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>metadata is the standard object metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
            ///
            /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.HorizontalPodAutoscaler#metadata
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
            public K8s.IObjectMeta? Metadata
            {
                get => GetInstanceProperty<K8s.IObjectMeta?>();
            }

            /// <summary>spec is the specification for the behaviour of the autoscaler.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status.
            ///
            /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.HorizontalPodAutoscaler#spec
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.HorizontalPodAutoscalerSpecV2\"}", isOptional: true)]
            public K8s.IHorizontalPodAutoscalerSpecV2? Spec
            {
                get => GetInstanceProperty<K8s.IHorizontalPodAutoscalerSpecV2?>();
            }
        }
    }
}
