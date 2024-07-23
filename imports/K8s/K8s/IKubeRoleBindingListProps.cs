using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>RoleBindingList is a collection of RoleBindings.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.rbac.v1.RoleBindingList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeRoleBindingListProps), fullyQualifiedName: "k8s.KubeRoleBindingListProps")]
    public interface IKubeRoleBindingListProps
    {
        /// <summary>Items is a list of RoleBindings.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.RoleBindingList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeRoleBindingProps\"},\"kind\":\"array\"}}")]
        K8s.IKubeRoleBindingProps[] Items
        {
            get;
        }

        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.RoleBindingList#metadata
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

        /// <summary>RoleBindingList is a collection of RoleBindings.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.RoleBindingList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeRoleBindingListProps), fullyQualifiedName: "k8s.KubeRoleBindingListProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeRoleBindingListProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Items is a list of RoleBindings.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.rbac.v1.RoleBindingList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeRoleBindingProps\"},\"kind\":\"array\"}}")]
            public K8s.IKubeRoleBindingProps[] Items
            {
                get => GetInstanceProperty<K8s.IKubeRoleBindingProps[]>()!;
            }

            /// <summary>Standard object's metadata.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.rbac.v1.RoleBindingList#metadata
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
