using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>ExternalMetricSource indicates how to scale on a metric not associated with any Kubernetes object (for example length of queue in cloud messaging service, or QPS from loadbalancer running outside of cluster).</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.ExternalMetricSource
    /// </remarks>
    [JsiiByValue(fqn: "k8s.ExternalMetricSourceV2")]
    public class ExternalMetricSourceV2 : K8s.IExternalMetricSourceV2
    {
        /// <summary>metric identifies the target metric by name and selector.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.ExternalMetricSource#metric
        /// </remarks>
        [JsiiProperty(name: "metric", typeJson: "{\"fqn\":\"k8s.MetricIdentifierV2\"}")]
        public K8s.IMetricIdentifierV2 Metric
        {
            get;
            set;
        }

        /// <summary>target specifies the target value for the given metric.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.ExternalMetricSource#target
        /// </remarks>
        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"k8s.MetricTargetV2\"}")]
        public K8s.IMetricTargetV2 Target
        {
            get;
            set;
        }
    }
}
