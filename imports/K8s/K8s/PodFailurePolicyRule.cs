using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>PodFailurePolicyRule describes how a pod failure is handled when the requirements are met.</summary>
    /// <remarks>
    /// One of onExitCodes and onPodConditions, but not both, can be used in each rule.
    ///
    /// <strong>Schema</strong>: io.k8s.api.batch.v1.PodFailurePolicyRule
    /// </remarks>
    [JsiiByValue(fqn: "k8s.PodFailurePolicyRule")]
    public class PodFailurePolicyRule : K8s.IPodFailurePolicyRule
    {
        /// <summary>Specifies the action taken on a pod failure when the requirements are satisfied. Possible values are:.</summary>
        /// <remarks>
        /// <list type="bullet">
        /// <description>FailJob: indicates that the pod's job is marked as Failed and all
        /// running pods are terminated.</description>
        /// <description>FailIndex: indicates that the pod's index is marked as Failed and will
        /// not be restarted.
        /// This value is beta-level. It can be used when the
        /// <c>JobBackoffLimitPerIndex</c> feature gate is enabled (enabled by default).</description>
        /// <description>Ignore: indicates that the counter towards the .backoffLimit is not
        /// incremented and a replacement pod is created.</description>
        /// <description>Count: indicates that the pod is handled in the default way - the
        /// counter towards the .backoffLimit is incremented.
        /// Additional values are considered to be added in the future. Clients should react to an unknown action by skipping the rule.</description>
        /// </list>
        ///
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.PodFailurePolicyRule#action
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public string Action
        {
            get;
            set;
        }

        /// <summary>Represents the requirement on the container exit codes.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.PodFailurePolicyRule#onExitCodes
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "onExitCodes", typeJson: "{\"fqn\":\"k8s.PodFailurePolicyOnExitCodesRequirement\"}", isOptional: true)]
        public K8s.IPodFailurePolicyOnExitCodesRequirement? OnExitCodes
        {
            get;
            set;
        }

        /// <summary>Represents the requirement on the pod conditions.</summary>
        /// <remarks>
        /// The requirement is represented as a list of pod condition patterns. The requirement is satisfied if at least one pattern matches an actual pod condition. At most 20 elements are allowed.
        ///
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.PodFailurePolicyRule#onPodConditions
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "onPodConditions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.PodFailurePolicyOnPodConditionsPattern\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.IPodFailurePolicyOnPodConditionsPattern[]? OnPodConditions
        {
            get;
            set;
        }
    }
}
