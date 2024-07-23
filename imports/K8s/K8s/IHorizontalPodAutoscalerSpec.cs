using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>specification of a horizontal pod autoscaler.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.autoscaling.v1.HorizontalPodAutoscalerSpec
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IHorizontalPodAutoscalerSpec), fullyQualifiedName: "k8s.HorizontalPodAutoscalerSpec")]
    public interface IHorizontalPodAutoscalerSpec
    {
        /// <summary>maxReplicas is the upper limit for the number of pods that can be set by the autoscaler;</summary>
        /// <remarks>
        /// cannot be smaller than MinReplicas.
        ///
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v1.HorizontalPodAutoscalerSpec#maxReplicas
        /// </remarks>
        [JsiiProperty(name: "maxReplicas", typeJson: "{\"primitive\":\"number\"}")]
        double MaxReplicas
        {
            get;
        }

        /// <summary>reference to scaled resource;</summary>
        /// <remarks>
        /// horizontal pod autoscaler will learn the current resource consumption and will set the desired number of pods by using its Scale subresource.
        ///
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v1.HorizontalPodAutoscalerSpec#scaleTargetRef
        /// </remarks>
        [JsiiProperty(name: "scaleTargetRef", typeJson: "{\"fqn\":\"k8s.CrossVersionObjectReference\"}")]
        K8s.ICrossVersionObjectReference ScaleTargetRef
        {
            get;
        }

        /// <summary>minReplicas is the lower limit for the number of replicas to which the autoscaler can scale down.</summary>
        /// <remarks>
        /// It defaults to 1 pod.  minReplicas is allowed to be 0 if the alpha feature gate HPAScaleToZero is enabled and at least one Object or External metric is configured.  Scaling is active as long as at least one metric value is available.
        ///
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v1.HorizontalPodAutoscalerSpec#minReplicas
        /// </remarks>
        [JsiiProperty(name: "minReplicas", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinReplicas
        {
            get
            {
                return null;
            }
        }

        /// <summary>targetCPUUtilizationPercentage is the target average CPU utilization (represented as a percentage of requested CPU) over all the pods;</summary>
        /// <remarks>
        /// if not specified the default autoscaling policy will be used.
        ///
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v1.HorizontalPodAutoscalerSpec#targetCPUUtilizationPercentage
        /// </remarks>
        [JsiiProperty(name: "targetCpuUtilizationPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TargetCpuUtilizationPercentage
        {
            get
            {
                return null;
            }
        }

        /// <summary>specification of a horizontal pod autoscaler.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v1.HorizontalPodAutoscalerSpec
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IHorizontalPodAutoscalerSpec), fullyQualifiedName: "k8s.HorizontalPodAutoscalerSpec")]
        internal sealed class _Proxy : DeputyBase, K8s.IHorizontalPodAutoscalerSpec
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>maxReplicas is the upper limit for the number of pods that can be set by the autoscaler;</summary>
            /// <remarks>
            /// cannot be smaller than MinReplicas.
            ///
            /// <strong>Schema</strong>: io.k8s.api.autoscaling.v1.HorizontalPodAutoscalerSpec#maxReplicas
            /// </remarks>
            [JsiiProperty(name: "maxReplicas", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxReplicas
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>reference to scaled resource;</summary>
            /// <remarks>
            /// horizontal pod autoscaler will learn the current resource consumption and will set the desired number of pods by using its Scale subresource.
            ///
            /// <strong>Schema</strong>: io.k8s.api.autoscaling.v1.HorizontalPodAutoscalerSpec#scaleTargetRef
            /// </remarks>
            [JsiiProperty(name: "scaleTargetRef", typeJson: "{\"fqn\":\"k8s.CrossVersionObjectReference\"}")]
            public K8s.ICrossVersionObjectReference ScaleTargetRef
            {
                get => GetInstanceProperty<K8s.ICrossVersionObjectReference>()!;
            }

            /// <summary>minReplicas is the lower limit for the number of replicas to which the autoscaler can scale down.</summary>
            /// <remarks>
            /// It defaults to 1 pod.  minReplicas is allowed to be 0 if the alpha feature gate HPAScaleToZero is enabled and at least one Object or External metric is configured.  Scaling is active as long as at least one metric value is available.
            ///
            /// <strong>Schema</strong>: io.k8s.api.autoscaling.v1.HorizontalPodAutoscalerSpec#minReplicas
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "minReplicas", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinReplicas
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>targetCPUUtilizationPercentage is the target average CPU utilization (represented as a percentage of requested CPU) over all the pods;</summary>
            /// <remarks>
            /// if not specified the default autoscaling policy will be used.
            ///
            /// <strong>Schema</strong>: io.k8s.api.autoscaling.v1.HorizontalPodAutoscalerSpec#targetCPUUtilizationPercentage
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "targetCpuUtilizationPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TargetCpuUtilizationPercentage
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
