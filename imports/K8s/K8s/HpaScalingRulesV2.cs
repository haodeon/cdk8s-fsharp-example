using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>HPAScalingRules configures the scaling behavior for one direction.</summary>
    /// <remarks>
    /// These Rules are applied after calculating DesiredReplicas from metrics for the HPA. They can limit the scaling velocity by specifying scaling policies. They can prevent flapping by specifying the stabilization window, so that the number of replicas is not set instantly, instead, the safest value from the stabilization window is chosen.
    ///
    /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.HPAScalingRules
    /// </remarks>
    [JsiiByValue(fqn: "k8s.HpaScalingRulesV2")]
    public class HpaScalingRulesV2 : K8s.IHpaScalingRulesV2
    {
        /// <summary>policies is a list of potential scaling polices which can be used during scaling.</summary>
        /// <remarks>
        /// At least one policy must be specified, otherwise the HPAScalingRules will be discarded as invalid
        ///
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.HPAScalingRules#policies
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "policies", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.HpaScalingPolicyV2\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.IHpaScalingPolicyV2[]? Policies
        {
            get;
            set;
        }

        /// <summary>selectPolicy is used to specify which policy should be used.</summary>
        /// <remarks>
        /// If not set, the default value Max is used.
        ///
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.HPAScalingRules#selectPolicy
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "selectPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SelectPolicy
        {
            get;
            set;
        }

        /// <summary>stabilizationWindowSeconds is the number of seconds for which past recommendations should be considered while scaling up or scaling down.</summary>
        /// <remarks>
        /// StabilizationWindowSeconds must be greater than or equal to zero and less than or equal to 3600 (one hour). If not set, use the default values: - For scale up: 0 (i.e. no stabilization is done). - For scale down: 300 (i.e. the stabilization window is 300 seconds long).
        ///
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.HPAScalingRules#stabilizationWindowSeconds
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stabilizationWindowSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? StabilizationWindowSeconds
        {
            get;
            set;
        }
    }
}
