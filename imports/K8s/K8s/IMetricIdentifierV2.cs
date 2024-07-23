using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>MetricIdentifier defines the name and optionally selector for a metric.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.MetricIdentifier
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IMetricIdentifierV2), fullyQualifiedName: "k8s.MetricIdentifierV2")]
    public interface IMetricIdentifierV2
    {
        /// <summary>name is the name of the given metric.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.MetricIdentifier#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>selector is the string-encoded form of a standard kubernetes label selector for the given metric When set, it is passed as an additional parameter to the metrics server for more specific metrics scoping.</summary>
        /// <remarks>
        /// When unset, just the metricName will be used to gather metrics.
        ///
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.MetricIdentifier#selector
        /// </remarks>
        [JsiiProperty(name: "selector", typeJson: "{\"fqn\":\"k8s.LabelSelector\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ILabelSelector? Selector
        {
            get
            {
                return null;
            }
        }

        /// <summary>MetricIdentifier defines the name and optionally selector for a metric.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.MetricIdentifier
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IMetricIdentifierV2), fullyQualifiedName: "k8s.MetricIdentifierV2")]
        internal sealed class _Proxy : DeputyBase, K8s.IMetricIdentifierV2
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>name is the name of the given metric.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.MetricIdentifier#name
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>selector is the string-encoded form of a standard kubernetes label selector for the given metric When set, it is passed as an additional parameter to the metrics server for more specific metrics scoping.</summary>
            /// <remarks>
            /// When unset, just the metricName will be used to gather metrics.
            ///
            /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.MetricIdentifier#selector
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "selector", typeJson: "{\"fqn\":\"k8s.LabelSelector\"}", isOptional: true)]
            public K8s.ILabelSelector? Selector
            {
                get => GetInstanceProperty<K8s.ILabelSelector?>();
            }
        }
    }
}
