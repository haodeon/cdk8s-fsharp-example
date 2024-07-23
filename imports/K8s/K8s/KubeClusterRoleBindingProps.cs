using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>ClusterRoleBinding references a ClusterRole, but not contain it.</summary>
    /// <remarks>
    /// It can reference a ClusterRole in the global namespace, and adds who information via Subject.
    ///
    /// <strong>Schema</strong>: io.k8s.api.rbac.v1.ClusterRoleBinding
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeClusterRoleBindingProps")]
    public class KubeClusterRoleBindingProps : K8s.IKubeClusterRoleBindingProps
    {
        /// <summary>RoleRef can only reference a ClusterRole in the global namespace.</summary>
        /// <remarks>
        /// If the RoleRef cannot be resolved, the Authorizer must return an error. This field is immutable.
        ///
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.ClusterRoleBinding#roleRef
        /// </remarks>
        [JsiiProperty(name: "roleRef", typeJson: "{\"fqn\":\"k8s.RoleRef\"}")]
        public K8s.IRoleRef RoleRef
        {
            get;
            set;
        }

        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.ClusterRoleBinding#metadata
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        public K8s.IObjectMeta? Metadata
        {
            get;
            set;
        }

        /// <summary>Subjects holds references to the objects the role applies to.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.ClusterRoleBinding#subjects
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "subjects", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.Subject\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.ISubject[]? Subjects
        {
            get;
            set;
        }
    }
}
