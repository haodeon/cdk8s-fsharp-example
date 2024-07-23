using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>ObjectMetricSource indicates how to scale on a metric describing a kubernetes object (for example, hits-per-second on an Ingress object).</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.ObjectMetricSource
    /// </remarks>
    [JsiiByValue(fqn: "k8s.ObjectMetricSourceV2")]
    public class ObjectMetricSourceV2 : K8s.IObjectMetricSourceV2
    {
        /// <summary>describedObject specifies the descriptions of a object,such as kind,name apiVersion.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.ObjectMetricSource#describedObject
        /// </remarks>
        [JsiiProperty(name: "describedObject", typeJson: "{\"fqn\":\"k8s.CrossVersionObjectReferenceV2\"}")]
        public K8s.ICrossVersionObjectReferenceV2 DescribedObject
        {
            get;
            set;
        }

        /// <summary>metric identifies the target metric by name and selector.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.ObjectMetricSource#metric
        /// </remarks>
        [JsiiProperty(name: "metric", typeJson: "{\"fqn\":\"k8s.MetricIdentifierV2\"}")]
        public K8s.IMetricIdentifierV2 Metric
        {
            get;
            set;
        }

        /// <summary>target specifies the target value for the given metric.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.ObjectMetricSource#target
        /// </remarks>
        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"k8s.MetricTargetV2\"}")]
        public K8s.IMetricTargetV2 Target
        {
            get;
            set;
        }
    }
}
