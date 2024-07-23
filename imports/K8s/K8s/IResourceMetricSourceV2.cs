using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ResourceMetricSource indicates how to scale on a resource metric known to Kubernetes, as specified in requests and limits, describing each pod in the current scale target (e.g. CPU or memory).  The values will be averaged together before being compared to the target.  Such metrics are built in to Kubernetes, and have special scaling options on top of those available to normal per-pod metrics using the "pods" source.  Only one "target" type should be set.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.ResourceMetricSource
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IResourceMetricSourceV2), fullyQualifiedName: "k8s.ResourceMetricSourceV2")]
    public interface IResourceMetricSourceV2
    {
        /// <summary>name is the name of the resource in question.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.ResourceMetricSource#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>target specifies the target value for the given metric.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.ResourceMetricSource#target
        /// </remarks>
        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"k8s.MetricTargetV2\"}")]
        K8s.IMetricTargetV2 Target
        {
            get;
        }

        /// <summary>ResourceMetricSource indicates how to scale on a resource metric known to Kubernetes, as specified in requests and limits, describing each pod in the current scale target (e.g. CPU or memory).  The values will be averaged together before being compared to the target.  Such metrics are built in to Kubernetes, and have special scaling options on top of those available to normal per-pod metrics using the "pods" source.  Only one "target" type should be set.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.ResourceMetricSource
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IResourceMetricSourceV2), fullyQualifiedName: "k8s.ResourceMetricSourceV2")]
        internal sealed class _Proxy : DeputyBase, K8s.IResourceMetricSourceV2
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>name is the name of the resource in question.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.ResourceMetricSource#name
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>target specifies the target value for the given metric.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.ResourceMetricSource#target
            /// </remarks>
            [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"k8s.MetricTargetV2\"}")]
            public K8s.IMetricTargetV2 Target
            {
                get => GetInstanceProperty<K8s.IMetricTargetV2>()!;
            }
        }
    }
}
