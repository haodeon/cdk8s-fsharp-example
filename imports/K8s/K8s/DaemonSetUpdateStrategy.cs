using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>DaemonSetUpdateStrategy is a struct used to control the update strategy for a DaemonSet.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.apps.v1.DaemonSetUpdateStrategy
    /// </remarks>
    [JsiiByValue(fqn: "k8s.DaemonSetUpdateStrategy")]
    public class DaemonSetUpdateStrategy : K8s.IDaemonSetUpdateStrategy
    {
        /// <summary>Rolling update config params.</summary>
        /// <remarks>
        /// Present only if type = "RollingUpdate".
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.DaemonSetUpdateStrategy#rollingUpdate
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rollingUpdate", typeJson: "{\"fqn\":\"k8s.RollingUpdateDaemonSet\"}", isOptional: true)]
        public K8s.IRollingUpdateDaemonSet? RollingUpdate
        {
            get;
            set;
        }

        /// <summary>Type of daemon set update.</summary>
        /// <remarks>
        /// Can be "RollingUpdate" or "OnDelete". Default is RollingUpdate.
        ///
        /// <strong>Default</strong>: RollingUpdate.
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.DaemonSetUpdateStrategy#type
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}
