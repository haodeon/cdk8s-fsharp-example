using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Deployment enables declarative updates for Pods and ReplicaSets.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.apps.v1.Deployment
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeDeploymentProps")]
    public class KubeDeploymentProps : K8s.IKubeDeploymentProps
    {
        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.Deployment#metadata
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        public K8s.IObjectMeta? Metadata
        {
            get;
            set;
        }

        /// <summary>Specification of the desired behavior of the Deployment.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.Deployment#spec
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.DeploymentSpec\"}", isOptional: true)]
        public K8s.IDeploymentSpec? Spec
        {
            get;
            set;
        }
    }
}
