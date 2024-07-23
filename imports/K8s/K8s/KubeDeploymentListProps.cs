using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>DeploymentList is a list of Deployments.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.apps.v1.DeploymentList
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeDeploymentListProps")]
    public class KubeDeploymentListProps : K8s.IKubeDeploymentListProps
    {
        /// <summary>Items is the list of Deployments.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.DeploymentList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeDeploymentProps\"},\"kind\":\"array\"}}")]
        public K8s.IKubeDeploymentProps[] Items
        {
            get;
            set;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.DeploymentList#metadata
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ListMeta\"}", isOptional: true)]
        public K8s.IListMeta? Metadata
        {
            get;
            set;
        }
    }
}
