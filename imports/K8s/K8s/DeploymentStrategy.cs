using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>DeploymentStrategy describes how to replace existing pods with new ones.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.apps.v1.DeploymentStrategy
    /// </remarks>
    [JsiiByValue(fqn: "k8s.DeploymentStrategy")]
    public class DeploymentStrategy : K8s.IDeploymentStrategy
    {
        /// <summary>Rolling update config params.</summary>
        /// <remarks>
        /// Present only if DeploymentStrategyType = RollingUpdate.
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.DeploymentStrategy#rollingUpdate
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rollingUpdate", typeJson: "{\"fqn\":\"k8s.RollingUpdateDeployment\"}", isOptional: true)]
        public K8s.IRollingUpdateDeployment? RollingUpdate
        {
            get;
            set;
        }

        /// <summary>Type of deployment.</summary>
        /// <remarks>
        /// Can be "Recreate" or "RollingUpdate". Default is RollingUpdate.
        ///
        /// <strong>Default</strong>: RollingUpdate.
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.DeploymentStrategy#type
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
