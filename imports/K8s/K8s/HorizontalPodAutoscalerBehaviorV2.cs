using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>HorizontalPodAutoscalerBehavior configures the scaling behavior of the target in both Up and Down directions (scaleUp and scaleDown fields respectively).</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.HorizontalPodAutoscalerBehavior
    /// </remarks>
    [JsiiByValue(fqn: "k8s.HorizontalPodAutoscalerBehaviorV2")]
    public class HorizontalPodAutoscalerBehaviorV2 : K8s.IHorizontalPodAutoscalerBehaviorV2
    {
        /// <summary>scaleDown is scaling policy for scaling Down.</summary>
        /// <remarks>
        /// If not set, the default value is to allow to scale down to minReplicas pods, with a 300 second stabilization window (i.e., the highest recommendation for the last 300sec is used).
        ///
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.HorizontalPodAutoscalerBehavior#scaleDown
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scaleDown", typeJson: "{\"fqn\":\"k8s.HpaScalingRulesV2\"}", isOptional: true)]
        public K8s.IHpaScalingRulesV2? ScaleDown
        {
            get;
            set;
        }

        /// <summary>scaleUp is scaling policy for scaling Up.</summary>
        /// <remarks>
        /// If not set, the default value is the higher of:
        ///
        /// <list type="bullet">
        /// <description>increase no more than 4 pods per 60 seconds</description>
        /// <description>double the number of pods per 60 seconds
        /// No stabilization is used.</description>
        /// </list>
        ///
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.HorizontalPodAutoscalerBehavior#scaleUp
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scaleUp", typeJson: "{\"fqn\":\"k8s.HpaScalingRulesV2\"}", isOptional: true)]
        public K8s.IHpaScalingRulesV2? ScaleUp
        {
            get;
            set;
        }
    }
}
