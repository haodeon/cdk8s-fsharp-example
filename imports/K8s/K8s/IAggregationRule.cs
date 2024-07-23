using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>AggregationRule describes how to locate ClusterRoles to aggregate into the ClusterRole.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.rbac.v1.AggregationRule
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IAggregationRule), fullyQualifiedName: "k8s.AggregationRule")]
    public interface IAggregationRule
    {
        /// <summary>ClusterRoleSelectors holds a list of selectors which will be used to find ClusterRoles and create the rules.</summary>
        /// <remarks>
        /// If any of the selectors match, then the ClusterRole's permissions will be added
        ///
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.AggregationRule#clusterRoleSelectors
        /// </remarks>
        [JsiiProperty(name: "clusterRoleSelectors", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.LabelSelector\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ILabelSelector[]? ClusterRoleSelectors
        {
            get
            {
                return null;
            }
        }

        /// <summary>AggregationRule describes how to locate ClusterRoles to aggregate into the ClusterRole.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.AggregationRule
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IAggregationRule), fullyQualifiedName: "k8s.AggregationRule")]
        internal sealed class _Proxy : DeputyBase, K8s.IAggregationRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ClusterRoleSelectors holds a list of selectors which will be used to find ClusterRoles and create the rules.</summary>
            /// <remarks>
            /// If any of the selectors match, then the ClusterRole's permissions will be added
            ///
            /// <strong>Schema</strong>: io.k8s.api.rbac.v1.AggregationRule#clusterRoleSelectors
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clusterRoleSelectors", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.LabelSelector\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.ILabelSelector[]? ClusterRoleSelectors
            {
                get => GetInstanceProperty<K8s.ILabelSelector[]?>();
            }
        }
    }
}
