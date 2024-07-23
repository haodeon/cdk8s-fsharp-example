using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>RoleBindingList is a collection of RoleBindings.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.rbac.v1.RoleBindingList
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeRoleBindingListProps")]
    public class KubeRoleBindingListProps : K8s.IKubeRoleBindingListProps
    {
        /// <summary>Items is a list of RoleBindings.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.RoleBindingList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeRoleBindingProps\"},\"kind\":\"array\"}}")]
        public K8s.IKubeRoleBindingProps[] Items
        {
            get;
            set;
        }

        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.RoleBindingList#metadata
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
