using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>HorizontalPodAutoscalerSpec describes the desired functionality of the HorizontalPodAutoscaler.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.HorizontalPodAutoscalerSpec
    /// </remarks>
    [JsiiByValue(fqn: "k8s.HorizontalPodAutoscalerSpecV2")]
    public class HorizontalPodAutoscalerSpecV2 : K8s.IHorizontalPodAutoscalerSpecV2
    {
        /// <summary>maxReplicas is the upper limit for the number of replicas to which the autoscaler can scale up.</summary>
        /// <remarks>
        /// It cannot be less that minReplicas.
        ///
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.HorizontalPodAutoscalerSpec#maxReplicas
        /// </remarks>
        [JsiiProperty(name: "maxReplicas", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxReplicas
        {
            get;
            set;
        }

        /// <summary>scaleTargetRef points to the target resource to scale, and is used to the pods for which metrics should be collected, as well as to actually change the replica count.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.HorizontalPodAutoscalerSpec#scaleTargetRef
        /// </remarks>
        [JsiiProperty(name: "scaleTargetRef", typeJson: "{\"fqn\":\"k8s.CrossVersionObjectReferenceV2\"}")]
        public K8s.ICrossVersionObjectReferenceV2 ScaleTargetRef
        {
            get;
            set;
        }

        /// <summary>behavior configures the scaling behavior of the target in both Up and Down directions (scaleUp and scaleDown fields respectively).</summary>
        /// <remarks>
        /// If not set, the default HPAScalingRules for scale up and scale down are used.
        ///
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.HorizontalPodAutoscalerSpec#behavior
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "behavior", typeJson: "{\"fqn\":\"k8s.HorizontalPodAutoscalerBehaviorV2\"}", isOptional: true)]
        public K8s.IHorizontalPodAutoscalerBehaviorV2? Behavior
        {
            get;
            set;
        }

        /// <summary>metrics contains the specifications for which to use to calculate the desired replica count (the maximum replica count across all metrics will be used).</summary>
        /// <remarks>
        /// The desired replica count is calculated multiplying the ratio between the target value and the current value by the current number of pods.  Ergo, metrics used must decrease as the pod count is increased, and vice-versa.  See the individual metric source types for more information about how each type of metric must respond. If not set, the default metric will be set to 80% average CPU utilization.
        ///
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.HorizontalPodAutoscalerSpec#metrics
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metrics", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.MetricSpecV2\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.IMetricSpecV2[]? Metrics
        {
            get;
            set;
        }

        /// <summary>minReplicas is the lower limit for the number of replicas to which the autoscaler can scale down.</summary>
        /// <remarks>
        /// It defaults to 1 pod.  minReplicas is allowed to be 0 if the alpha feature gate HPAScaleToZero is enabled and at least one Object or External metric is configured.  Scaling is active as long as at least one metric value is available.
        ///
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.HorizontalPodAutoscalerSpec#minReplicas
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "minReplicas", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinReplicas
        {
            get;
            set;
        }
    }
}
