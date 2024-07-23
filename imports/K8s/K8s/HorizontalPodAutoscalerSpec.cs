using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>specification of a horizontal pod autoscaler.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.autoscaling.v1.HorizontalPodAutoscalerSpec
    /// </remarks>
    [JsiiByValue(fqn: "k8s.HorizontalPodAutoscalerSpec")]
    public class HorizontalPodAutoscalerSpec : K8s.IHorizontalPodAutoscalerSpec
    {
        /// <summary>maxReplicas is the upper limit for the number of pods that can be set by the autoscaler;</summary>
        /// <remarks>
        /// cannot be smaller than MinReplicas.
        ///
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v1.HorizontalPodAutoscalerSpec#maxReplicas
        /// </remarks>
        [JsiiProperty(name: "maxReplicas", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxReplicas
        {
            get;
            set;
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
            get;
            set;
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
            get;
            set;
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
            get;
            set;
        }
    }
}
