using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ClusterRoleBindingList is a collection of ClusterRoleBindings.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.rbac.v1.ClusterRoleBindingList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeClusterRoleBindingListProps), fullyQualifiedName: "k8s.KubeClusterRoleBindingListProps")]
    public interface IKubeClusterRoleBindingListProps
    {
        /// <summary>Items is a list of ClusterRoleBindings.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.ClusterRoleBindingList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeClusterRoleBindingProps\"},\"kind\":\"array\"}}")]
        K8s.IKubeClusterRoleBindingProps[] Items
        {
            get;
        }

        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.ClusterRoleBindingList#metadata
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

        /// <summary>ClusterRoleBindingList is a collection of ClusterRoleBindings.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.ClusterRoleBindingList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeClusterRoleBindingListProps), fullyQualifiedName: "k8s.KubeClusterRoleBindingListProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeClusterRoleBindingListProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Items is a list of ClusterRoleBindings.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.rbac.v1.ClusterRoleBindingList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeClusterRoleBindingProps\"},\"kind\":\"array\"}}")]
            public K8s.IKubeClusterRoleBindingProps[] Items
            {
                get => GetInstanceProperty<K8s.IKubeClusterRoleBindingProps[]>()!;
            }

            /// <summary>Standard object's metadata.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.rbac.v1.ClusterRoleBindingList#metadata
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
