using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>PriorityLevelConfiguration represents the configuration of a priority level.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.PriorityLevelConfiguration
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubePriorityLevelConfigurationProps")]
    public class KubePriorityLevelConfigurationProps : K8s.IKubePriorityLevelConfigurationProps
    {
        /// <summary>`metadata` is the standard object's metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.PriorityLevelConfiguration#metadata
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        public K8s.IObjectMeta? Metadata
        {
            get;
            set;
        }

        /// <summary>`spec` is the specification of the desired behavior of a "request-priority".</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.PriorityLevelConfiguration#spec
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.PriorityLevelConfigurationSpec\"}", isOptional: true)]
        public K8s.IPriorityLevelConfigurationSpec? Spec
        {
            get;
            set;
        }
    }
}
