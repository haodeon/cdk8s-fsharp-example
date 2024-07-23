using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ClusterRole is a cluster level, logical grouping of PolicyRules that can be referenced as a unit by a RoleBinding or ClusterRoleBinding.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.rbac.v1.ClusterRole
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeClusterRoleProps")]
    public class KubeClusterRoleProps : K8s.IKubeClusterRoleProps
    {
        /// <summary>AggregationRule is an optional field that describes how to build the Rules for this ClusterRole.</summary>
        /// <remarks>
        /// If AggregationRule is set, then the Rules are controller managed and direct changes to Rules will be stomped by the controller.
        ///
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.ClusterRole#aggregationRule
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "aggregationRule", typeJson: "{\"fqn\":\"k8s.AggregationRule\"}", isOptional: true)]
        public K8s.IAggregationRule? AggregationRule
        {
            get;
            set;
        }

        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.ClusterRole#metadata
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        public K8s.IObjectMeta? Metadata
        {
            get;
            set;
        }

        /// <summary>Rules holds all the PolicyRules for this ClusterRole.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.ClusterRole#rules
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
