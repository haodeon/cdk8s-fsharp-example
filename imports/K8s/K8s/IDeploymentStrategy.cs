using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>DeploymentStrategy describes how to replace existing pods with new ones.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.apps.v1.DeploymentStrategy
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IDeploymentStrategy), fullyQualifiedName: "k8s.DeploymentStrategy")]
    public interface IDeploymentStrategy
    {
        /// <summary>Rolling update config params.</summary>
        /// <remarks>
        /// Present only if DeploymentStrategyType = RollingUpdate.
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.DeploymentStrategy#rollingUpdate
        /// </remarks>
        [JsiiProperty(name: "rollingUpdate", typeJson: "{\"fqn\":\"k8s.RollingUpdateDeployment\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IRollingUpdateDeployment? RollingUpdate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Type of deployment.</summary>
        /// <remarks>
        /// Can be "Recreate" or "RollingUpdate". Default is RollingUpdate.
        ///
        /// <strong>Default</strong>: RollingUpdate.
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.DeploymentStrategy#type
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        /// <summary>DeploymentStrategy describes how to replace existing pods with new ones.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.DeploymentStrategy
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IDeploymentStrategy), fullyQualifiedName: "k8s.DeploymentStrategy")]
        internal sealed class _Proxy : DeputyBase, K8s.IDeploymentStrategy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

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
                get => GetInstanceProperty<K8s.IRollingUpdateDeployment?>();
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
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
