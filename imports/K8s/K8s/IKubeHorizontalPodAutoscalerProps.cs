using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>configuration of a horizontal pod autoscaler.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.autoscaling.v1.HorizontalPodAutoscaler
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeHorizontalPodAutoscalerProps), fullyQualifiedName: "k8s.KubeHorizontalPodAutoscalerProps")]
    public interface IKubeHorizontalPodAutoscalerProps
    {
        /// <summary>Standard object metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v1.HorizontalPodAutoscaler#metadata
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

        /// <summary>spec defines the behaviour of autoscaler.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status.
        ///
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v1.HorizontalPodAutoscaler#spec
        /// </remarks>
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.HorizontalPodAutoscalerSpec\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IHorizontalPodAutoscalerSpec? Spec
        {
            get
            {
                return null;
            }
        }

        /// <summary>configuration of a horizontal pod autoscaler.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v1.HorizontalPodAutoscaler
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeHorizontalPodAutoscalerProps), fullyQualifiedName: "k8s.KubeHorizontalPodAutoscalerProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeHorizontalPodAutoscalerProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Standard object metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
            ///
            /// <strong>Schema</strong>: io.k8s.api.autoscaling.v1.HorizontalPodAutoscaler#metadata
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
            public K8s.IObjectMeta? Metadata
            {
                get => GetInstanceProperty<K8s.IObjectMeta?>();
            }

            /// <summary>spec defines the behaviour of autoscaler.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status.
            ///
            /// <strong>Schema</strong>: io.k8s.api.autoscaling.v1.HorizontalPodAutoscaler#spec
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.HorizontalPodAutoscalerSpec\"}", isOptional: true)]
            public K8s.IHorizontalPodAutoscalerSpec? Spec
            {
                get => GetInstanceProperty<K8s.IHorizontalPodAutoscalerSpec?>();
            }
        }
    }
}
