using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>PodDisruptionBudgetSpec is a description of a PodDisruptionBudget.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.policy.v1.PodDisruptionBudgetSpec
    /// </remarks>
    [JsiiByValue(fqn: "k8s.PodDisruptionBudgetSpec")]
    public class PodDisruptionBudgetSpec : K8s.IPodDisruptionBudgetSpec
    {
        /// <summary>An eviction is allowed if at most "maxUnavailable" pods selected by "selector" are unavailable after the eviction, i.e. even in absence of the evicted pod. For example, one can prevent all voluntary evictions by specifying 0. This is a mutually exclusive setting with "minAvailable".</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.policy.v1.PodDisruptionBudgetSpec#maxUnavailable
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maxUnavailable", typeJson: "{\"fqn\":\"k8s.IntOrString\"}", isOptional: true)]
        public K8s.IntOrString? MaxUnavailable
        {
            get;
            set;
        }

        /// <summary>An eviction is allowed if at least "minAvailable" pods selected by "selector" will still be available after the eviction, i.e. even in the absence of the evicted pod.  So for example you can prevent all voluntary evictions by specifying "100%".</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.policy.v1.PodDisruptionBudgetSpec#minAvailable
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "minAvailable", typeJson: "{\"fqn\":\"k8s.IntOrString\"}", isOptional: true)]
        public K8s.IntOrString? MinAvailable
        {
            get;
            set;
        }

        /// <summary>Label query over pods whose evictions are managed by the disruption budget.</summary>
        /// <remarks>
        /// A null selector will match no pods, while an empty ({}) selector will select all pods within the namespace.
        ///
        /// <strong>Schema</strong>: io.k8s.api.policy.v1.PodDisruptionBudgetSpec#selector
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "selector", typeJson: "{\"fqn\":\"k8s.LabelSelector\"}", isOptional: true)]
        public K8s.ILabelSelector? Selector
        {
            get;
            set;
        }

        /// <summary>UnhealthyPodEvictionPolicy defines the criteria for when unhealthy pods should be considered for eviction.</summary>
        /// <remarks>
        /// Current implementation considers healthy pods, as pods that have status.conditions item with type="Ready",status="True".
        ///
        /// Valid policies are IfHealthyBudget and AlwaysAllow. If no policy is specified, the default behavior will be used, which corresponds to the IfHealthyBudget policy.
        ///
        /// IfHealthyBudget policy means that running pods (status.phase="Running"), but not yet healthy can be evicted only if the guarded application is not disrupted (status.currentHealthy is at least equal to status.desiredHealthy). Healthy pods will be subject to the PDB for eviction.
        ///
        /// AlwaysAllow policy means that all running pods (status.phase="Running"), but not yet healthy are considered disrupted and can be evicted regardless of whether the criteria in a PDB is met. This means perspective running pods of a disrupted application might not get a chance to become healthy. Healthy pods will be subject to the PDB for eviction.
        ///
        /// Additional policies may be added in the future. Clients making eviction decisions should disallow eviction of unhealthy pods if they encounter an unrecognized policy in this field.
        ///
        /// This field is beta-level. The eviction API uses this field when the feature gate PDBUnhealthyPodEvictionPolicy is enabled (enabled by default).
        ///
        /// <strong>Schema</strong>: io.k8s.api.policy.v1.PodDisruptionBudgetSpec#unhealthyPodEvictionPolicy
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "unhealthyPodEvictionPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UnhealthyPodEvictionPolicy
        {
            get;
            set;
        }
    }
}
