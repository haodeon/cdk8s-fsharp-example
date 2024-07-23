using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ClusterRole is a cluster level, logical grouping of PolicyRules that can be referenced as a unit by a RoleBinding or ClusterRoleBinding.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.rbac.v1.ClusterRole
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeClusterRoleProps), fullyQualifiedName: "k8s.KubeClusterRoleProps")]
    public interface IKubeClusterRoleProps
    {
        /// <summary>AggregationRule is an optional field that describes how to build the Rules for this ClusterRole.</summary>
        /// <remarks>
        /// If AggregationRule is set, then the Rules are controller managed and direct changes to Rules will be stomped by the controller.
        ///
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.ClusterRole#aggregationRule
        /// </remarks>
        [JsiiProperty(name: "aggregationRule", typeJson: "{\"fqn\":\"k8s.AggregationRule\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IAggregationRule? AggregationRule
        {
            get
            {
                return null;
            }
        }

        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.ClusterRole#metadata
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

        /// <summary>Rules holds all the PolicyRules for this ClusterRole.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.ClusterRole#rules
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

        /// <summary>ClusterRole is a cluster level, logical grouping of PolicyRules that can be referenced as a unit by a RoleBinding or ClusterRoleBinding.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.ClusterRole
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeClusterRoleProps), fullyQualifiedName: "k8s.KubeClusterRoleProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeClusterRoleProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

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
                get => GetInstanceProperty<K8s.IAggregationRule?>();
            }

            /// <summary>Standard object's metadata.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.rbac.v1.ClusterRole#metadata
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
            public K8s.IObjectMeta? Metadata
            {
                get => GetInstanceProperty<K8s.IObjectMeta?>();
            }

            /// <summary>Rules holds all the PolicyRules for this ClusterRole.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.rbac.v1.ClusterRole#rules
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
