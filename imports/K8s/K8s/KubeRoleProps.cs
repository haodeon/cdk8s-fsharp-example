using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Role is a namespaced, logical grouping of PolicyRules that can be referenced as a unit by a RoleBinding.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.rbac.v1.Role
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeRoleProps")]
    public class KubeRoleProps : K8s.IKubeRoleProps
    {
        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.Role#metadata
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        public K8s.IObjectMeta? Metadata
        {
            get;
            set;
        }

        /// <summary>Rules holds all the PolicyRules for this Role.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.Role#rules
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rules", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.PolicyRule\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.IPolicyRule[]? Rules
        {
            get;
            set;
        }
    }
}
