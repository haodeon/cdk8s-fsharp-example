using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ExternalMetricSource indicates how to scale on a metric not associated with any Kubernetes object (for example length of queue in cloud messaging service, or QPS from loadbalancer running outside of cluster).</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.ExternalMetricSource
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IExternalMetricSourceV2), fullyQualifiedName: "k8s.ExternalMetricSourceV2")]
    public interface IExternalMetricSourceV2
    {
        /// <summary>metric identifies the target metric by name and selector.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.ExternalMetricSource#metric
        /// </remarks>
        [JsiiProperty(name: "metric", typeJson: "{\"fqn\":\"k8s.MetricIdentifierV2\"}")]
        K8s.IMetricIdentifierV2 Metric
        {
            get;
        }

        /// <summary>target specifies the target value for the given metric.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.ExternalMetricSource#target
        /// </remarks>
        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"k8s.MetricTargetV2\"}")]
        K8s.IMetricTargetV2 Target
        {
            get;
        }

        /// <summary>ExternalMetricSource indicates how to scale on a metric not associated with any Kubernetes object (for example length of queue in cloud messaging service, or QPS from loadbalancer running outside of cluster).</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.ExternalMetricSource
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IExternalMetricSourceV2), fullyQualifiedName: "k8s.ExternalMetricSourceV2")]
        internal sealed class _Proxy : DeputyBase, K8s.IExternalMetricSourceV2
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>metric identifies the target metric by name and selector.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.ExternalMetricSource#metric
            /// </remarks>
            [JsiiProperty(name: "metric", typeJson: "{\"fqn\":\"k8s.MetricIdentifierV2\"}")]
            public K8s.IMetricIdentifierV2 Metric
            {
                get => GetInstanceProperty<K8s.IMetricIdentifierV2>()!;
            }

            /// <summary>target specifies the target value for the given metric.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.ExternalMetricSource#target
            /// </remarks>
            [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"k8s.MetricTargetV2\"}")]
            public K8s.IMetricTargetV2 Target
            {
                get => GetInstanceProperty<K8s.IMetricTargetV2>()!;
            }
        }
    }
}
