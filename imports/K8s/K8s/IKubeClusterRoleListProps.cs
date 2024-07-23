using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ClusterRoleList is a collection of ClusterRoles.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.rbac.v1.ClusterRoleList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeClusterRoleListProps), fullyQualifiedName: "k8s.KubeClusterRoleListProps")]
    public interface IKubeClusterRoleListProps
    {
        /// <summary>Items is a list of ClusterRoles.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.ClusterRoleList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeClusterRoleProps\"},\"kind\":\"array\"}}")]
        K8s.IKubeClusterRoleProps[] Items
        {
            get;
        }

        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.ClusterRoleList#metadata
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

        /// <summary>ClusterRoleList is a collection of ClusterRoles.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.ClusterRoleList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeClusterRoleListProps), fullyQualifiedName: "k8s.KubeClusterRoleListProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeClusterRoleListProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Items is a list of ClusterRoles.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.rbac.v1.ClusterRoleList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeClusterRoleProps\"},\"kind\":\"array\"}}")]
            public K8s.IKubeClusterRoleProps[] Items
            {
                get => GetInstanceProperty<K8s.IKubeClusterRoleProps[]>()!;
            }

            /// <summary>Standard object's metadata.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.rbac.v1.ClusterRoleList#metadata
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
