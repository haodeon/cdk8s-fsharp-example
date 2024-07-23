using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>ClusterRoleBindingList is a collection of ClusterRoleBindings.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.rbac.v1.ClusterRoleBindingList
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeClusterRoleBindingListProps")]
    public class KubeClusterRoleBindingListProps : K8s.IKubeClusterRoleBindingListProps
    {
        /// <summary>Items is a list of ClusterRoleBindings.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.ClusterRoleBindingList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeClusterRoleBindingProps\"},\"kind\":\"array\"}}")]
        public K8s.IKubeClusterRoleBindingProps[] Items
        {
            get;
            set;
        }

        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.ClusterRoleBindingList#metadata
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
