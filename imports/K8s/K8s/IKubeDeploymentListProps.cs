using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>DeploymentList is a list of Deployments.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.apps.v1.DeploymentList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeDeploymentListProps), fullyQualifiedName: "k8s.KubeDeploymentListProps")]
    public interface IKubeDeploymentListProps
    {
        /// <summary>Items is the list of Deployments.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.DeploymentList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeDeploymentProps\"},\"kind\":\"array\"}}")]
        K8s.IKubeDeploymentProps[] Items
        {
            get;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.DeploymentList#metadata
        /// </remarks>
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ListMeta\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IListMeta? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>DeploymentList is a list of Deployments.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.DeploymentList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeDeploymentListProps), fullyQualifiedName: "k8s.KubeDeploymentListProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeDeploymentListProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Items is the list of Deployments.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.apps.v1.DeploymentList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeDeploymentProps\"},\"kind\":\"array\"}}")]
            public K8s.IKubeDeploymentProps[] Items
            {
                get => GetInstanceProperty<K8s.IKubeDeploymentProps[]>()!;
            }

            /// <summary>Standard list metadata.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.apps.v1.DeploymentList#metadata
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ListMeta\"}", isOptional: true)]
            public K8s.IListMeta? Metadata
            {
                get => GetInstanceProperty<K8s.IListMeta?>();
            }
        }
    }
}
