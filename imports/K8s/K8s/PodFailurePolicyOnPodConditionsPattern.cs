using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>PodFailurePolicyOnPodConditionsPattern describes a pattern for matching an actual pod condition type.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.batch.v1.PodFailurePolicyOnPodConditionsPattern
    /// </remarks>
    [JsiiByValue(fqn: "k8s.PodFailurePolicyOnPodConditionsPattern")]
    public class PodFailurePolicyOnPodConditionsPattern : K8s.IPodFailurePolicyOnPodConditionsPattern
    {
        /// <summary>Specifies the required Pod condition status.</summary>
        /// <remarks>
        /// To match a pod condition it is required that the specified status equals the pod condition status. Defaults to True.
        ///
        /// <strong>Default</strong>: True.
        ///
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.PodFailurePolicyOnPodConditionsPattern#status
        /// </remarks>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public string Status
        {
            get;
            set;
        }

        /// <summary>Specifies the required Pod condition type.</summary>
        /// <remarks>
        /// To match a pod condition it is required that specified type equals the pod condition type.
        ///
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.PodFailurePolicyOnPodConditionsPattern#type
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
