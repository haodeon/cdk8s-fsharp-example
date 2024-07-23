using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>RoleBinding references a role, but does not contain it.</summary>
    /// <remarks>
    /// It can reference a Role in the same namespace or a ClusterRole in the global namespace. It adds who information via Subjects and namespace information by which namespace it exists in.  RoleBindings in a given namespace only have effect in that namespace.
    ///
    /// <strong>Schema</strong>: io.k8s.api.rbac.v1.RoleBinding
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeRoleBindingProps), fullyQualifiedName: "k8s.KubeRoleBindingProps")]
    public interface IKubeRoleBindingProps
    {
        /// <summary>RoleRef can reference a Role in the current namespace or a ClusterRole in the global namespace.</summary>
        /// <remarks>
        /// If the RoleRef cannot be resolved, the Authorizer must return an error. This field is immutable.
        ///
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.RoleBinding#roleRef
        /// </remarks>
        [JsiiProperty(name: "roleRef", typeJson: "{\"fqn\":\"k8s.RoleRef\"}")]
        K8s.IRoleRef RoleRef
        {
            get;
        }

        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.RoleBinding#metadata
        /// </remarks>
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IObjectMeta? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>Subjects holds references to the objects the role applies to.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.RoleBinding#subjects
        /// </remarks>
        [JsiiProperty(name: "subjects", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.Subject\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ISubject[]? Subjects
        {
            get
            {
                return null;
            }
        }

        /// <summary>RoleBinding references a role, but does not contain it.</summary>
        /// <remarks>
        /// It can reference a Role in the same namespace or a ClusterRole in the global namespace. It adds who information via Subjects and namespace information by which namespace it exists in.  RoleBindings in a given namespace only have effect in that namespace.
        ///
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.RoleBinding
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeRoleBindingProps), fullyQualifiedName: "k8s.KubeRoleBindingProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeRoleBindingProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>RoleRef can reference a Role in the current namespace or a ClusterRole in the global namespace.</summary>
            /// <remarks>
            /// If the RoleRef cannot be resolved, the Authorizer must return an error. This field is immutable.
            ///
            /// <strong>Schema</strong>: io.k8s.api.rbac.v1.RoleBinding#roleRef
            /// </remarks>
            [JsiiProperty(name: "roleRef", typeJson: "{\"fqn\":\"k8s.RoleRef\"}")]
            public K8s.IRoleRef RoleRef
            {
                get => GetInstanceProperty<K8s.IRoleRef>()!;
            }

            /// <summary>Standard object's metadata.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.rbac.v1.RoleBinding#metadata
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
            public K8s.IObjectMeta? Metadata
            {
                get => GetInstanceProperty<K8s.IObjectMeta?>();
            }

            /// <summary>Subjects holds references to the objects the role applies to.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.rbac.v1.RoleBinding#subjects
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "subjects", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.Subject\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.ISubject[]? Subjects
            {
                get => GetInstanceProperty<K8s.ISubject[]?>();
            }
        }
    }
}
