using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>MetricSpec specifies how to scale based on a single metric (only `type` and one other matching field should be set at once).</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.MetricSpec
    /// </remarks>
    [JsiiByValue(fqn: "k8s.MetricSpecV2")]
    public class MetricSpecV2 : K8s.IMetricSpecV2
    {
        /// <summary>type is the type of metric source.</summary>
        /// <remarks>
        /// It should be one of "ContainerResource", "External", "Object", "Pods" or "Resource", each mapping to a matching field in the object. Note: "ContainerResource" type is available on when the feature-gate HPAContainerMetrics is enabled
        ///
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.MetricSpec#type
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>containerResource refers to a resource metric (such as those specified in requests and limits) known to Kubernetes describing a single container in each pod of the current scale target (e.g. CPU or memory). Such metrics are built in to Kubernetes, and have special scaling options on top of those available to normal per-pod metrics using the "pods" source. This is an alpha feature and can be enabled by the HPAContainerMetrics feature flag.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.MetricSpec#containerResource
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "containerResource", typeJson: "{\"fqn\":\"k8s.ContainerResourceMetricSourceV2\"}", isOptional: true)]
        public K8s.IContainerResourceMetricSourceV2? ContainerResource
        {
            get;
            set;
        }

        /// <summary>external refers to a global metric that is not associated with any Kubernetes object.</summary>
        /// <remarks>
        /// It allows autoscaling based on information coming from components running outside of cluster (for example length of queue in cloud messaging service, or QPS from loadbalancer running outside of cluster).
        ///
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.MetricSpec#external
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "external", typeJson: "{\"fqn\":\"k8s.ExternalMetricSourceV2\"}", isOptional: true)]
        public K8s.IExternalMetricSourceV2? External
        {
            get;
            set;
        }

        /// <summary>object refers to a metric describing a single kubernetes object (for example, hits-per-second on an Ingress object).</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.MetricSpec#object
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "object", typeJson: "{\"fqn\":\"k8s.ObjectMetricSourceV2\"}", isOptional: true)]
        public K8s.IObjectMetricSourceV2? Object
        {
            get;
            set;
        }

        /// <summary>pods refers to a metric describing each pod in the current scale target (for example, transactions-processed-per-second).</summary>
        /// <remarks>
        /// The values will be averaged together before being compared to the target value.
        ///
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.MetricSpec#pods
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pods", typeJson: "{\"fqn\":\"k8s.PodsMetricSourceV2\"}", isOptional: true)]
        public K8s.IPodsMetricSourceV2? Pods
        {
            get;
            set;
        }

        /// <summary>resource refers to a resource metric (such as those specified in requests and limits) known to Kubernetes describing each pod in the current scale target (e.g. CPU or memory). Such metrics are built in to Kubernetes, and have special scaling options on top of those available to normal per-pod metrics using the "pods" source.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.MetricSpec#resource
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resource", typeJson: "{\"fqn\":\"k8s.ResourceMetricSourceV2\"}", isOptional: true)]
        public K8s.IResourceMetricSourceV2? Resource
        {
            get;
            set;
        }
    }
}
