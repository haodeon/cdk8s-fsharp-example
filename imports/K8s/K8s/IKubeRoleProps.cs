using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Role is a namespaced, logical grouping of PolicyRules that can be referenced as a unit by a RoleBinding.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.rbac.v1.Role
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeRoleProps), fullyQualifiedName: "k8s.KubeRoleProps")]
    public interface IKubeRoleProps
    {
        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.Role#metadata
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

        /// <summary>Rules holds all the PolicyRules for this Role.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.Role#rules
        /// </remarks>
        [JsiiProperty(name: "rules", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.PolicyRule\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IPolicyRule[]? Rules
        {
            get
            {
                return null;
            }
        }

        /// <summary>Role is a namespaced, logical grouping of PolicyRules that can be referenced as a unit by a RoleBinding.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.Role
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeRoleProps), fullyQualifiedName: "k8s.KubeRoleProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeRoleProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Standard object's metadata.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.rbac.v1.Role#metadata
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
            public K8s.IObjectMeta? Metadata
            {
                get => GetInstanceProperty<K8s.IObjectMeta?>();
            }

            /// <summary>Rules holds all the PolicyRules for this Role.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.rbac.v1.Role#rules
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rules", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.PolicyRule\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.IPolicyRule[]? Rules
            {
                get => GetInstanceProperty<K8s.IPolicyRule[]?>();
            }
        }
    }
}
