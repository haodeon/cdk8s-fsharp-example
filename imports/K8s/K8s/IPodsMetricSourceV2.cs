using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>PodsMetricSource indicates how to scale on a metric describing each pod in the current scale target (for example, transactions-processed-per-second).</summary>
    /// <remarks>
    /// The values will be averaged together before being compared to the target value.
    ///
    /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.PodsMetricSource
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IPodsMetricSourceV2), fullyQualifiedName: "k8s.PodsMetricSourceV2")]
    public interface IPodsMetricSourceV2
    {
        /// <summary>metric identifies the target metric by name and selector.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.PodsMetricSource#metric
        /// </remarks>
        [JsiiProperty(name: "metric", typeJson: "{\"fqn\":\"k8s.MetricIdentifierV2\"}")]
        K8s.IMetricIdentifierV2 Metric
        {
            get;
        }

        /// <summary>target specifies the target value for the given metric.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.PodsMetricSource#target
        /// </remarks>
        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"k8s.MetricTargetV2\"}")]
        K8s.IMetricTargetV2 Target
        {
            get;
        }

        /// <summary>PodsMetricSource indicates how to scale on a metric describing each pod in the current scale target (for example, transactions-processed-per-second).</summary>
        /// <remarks>
        /// The values will be averaged together before being compared to the target value.
        ///
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.PodsMetricSource
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IPodsMetricSourceV2), fullyQualifiedName: "k8s.PodsMetricSourceV2")]
        internal sealed class _Proxy : DeputyBase, K8s.IPodsMetricSourceV2
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>metric identifies the target metric by name and selector.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.PodsMetricSource#metric
            /// </remarks>
            [JsiiProperty(name: "metric", typeJson: "{\"fqn\":\"k8s.MetricIdentifierV2\"}")]
            public K8s.IMetricIdentifierV2 Metric
            {
                get => GetInstanceProperty<K8s.IMetricIdentifierV2>()!;
            }

            /// <summary>target specifies the target value for the given metric.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.PodsMetricSource#target
            /// </remarks>
            [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"k8s.MetricTargetV2\"}")]
            public K8s.IMetricTargetV2 Target
            {
                get => GetInstanceProperty<K8s.IMetricTargetV2>()!;
            }
        }
    }
}
