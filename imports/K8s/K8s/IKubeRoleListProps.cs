using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>RoleList is a collection of Roles.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.rbac.v1.RoleList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeRoleListProps), fullyQualifiedName: "k8s.KubeRoleListProps")]
    public interface IKubeRoleListProps
    {
        /// <summary>Items is a list of Roles.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.RoleList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeRoleProps\"},\"kind\":\"array\"}}")]
        K8s.IKubeRoleProps[] Items
        {
            get;
        }

        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.RoleList#metadata
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

        /// <summary>RoleList is a collection of Roles.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.RoleList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeRoleListProps), fullyQualifiedName: "k8s.KubeRoleListProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeRoleListProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Items is a list of Roles.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.rbac.v1.RoleList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeRoleProps\"},\"kind\":\"array\"}}")]
            public K8s.IKubeRoleProps[] Items
            {
                get => GetInstanceProperty<K8s.IKubeRoleProps[]>()!;
            }

            /// <summary>Standard object's metadata.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.rbac.v1.RoleList#metadata
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
