using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>MetricIdentifier defines the name and optionally selector for a metric.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.MetricIdentifier
    /// </remarks>
    [JsiiByValue(fqn: "k8s.MetricIdentifierV2")]
    public class MetricIdentifierV2 : K8s.IMetricIdentifierV2
    {
        /// <summary>name is the name of the given metric.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.MetricIdentifier#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
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
            get;
            set;
        }
    }
}
