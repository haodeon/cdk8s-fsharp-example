using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ObjectMetricSource indicates how to scale on a metric describing a kubernetes object (for example, hits-per-second on an Ingress object).</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.ObjectMetricSource
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IObjectMetricSourceV2), fullyQualifiedName: "k8s.ObjectMetricSourceV2")]
    public interface IObjectMetricSourceV2
    {
        /// <summary>describedObject specifies the descriptions of a object,such as kind,name apiVersion.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.ObjectMetricSource#describedObject
        /// </remarks>
        [JsiiProperty(name: "describedObject", typeJson: "{\"fqn\":\"k8s.CrossVersionObjectReferenceV2\"}")]
        K8s.ICrossVersionObjectReferenceV2 DescribedObject
        {
            get;
        }

        /// <summary>metric identifies the target metric by name and selector.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.ObjectMetricSource#metric
        /// </remarks>
        [JsiiProperty(name: "metric", typeJson: "{\"fqn\":\"k8s.MetricIdentifierV2\"}")]
        K8s.IMetricIdentifierV2 Metric
        {
            get;
        }

        /// <summary>target specifies the target value for the given metric.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.ObjectMetricSource#target
        /// </remarks>
        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"k8s.MetricTargetV2\"}")]
        K8s.IMetricTargetV2 Target
        {
            get;
        }

        /// <summary>ObjectMetricSource indicates how to scale on a metric describing a kubernetes object (for example, hits-per-second on an Ingress object).</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.ObjectMetricSource
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IObjectMetricSourceV2), fullyQualifiedName: "k8s.ObjectMetricSourceV2")]
        internal sealed class _Proxy : DeputyBase, K8s.IObjectMetricSourceV2
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>describedObject specifies the descriptions of a object,such as kind,name apiVersion.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.ObjectMetricSource#describedObject
            /// </remarks>
            [JsiiProperty(name: "describedObject", typeJson: "{\"fqn\":\"k8s.CrossVersionObjectReferenceV2\"}")]
            public K8s.ICrossVersionObjectReferenceV2 DescribedObject
            {
                get => GetInstanceProperty<K8s.ICrossVersionObjectReferenceV2>()!;
            }

            /// <summary>metric identifies the target metric by name and selector.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.ObjectMetricSource#metric
            /// </remarks>
            [JsiiProperty(name: "metric", typeJson: "{\"fqn\":\"k8s.MetricIdentifierV2\"}")]
            public K8s.IMetricIdentifierV2 Metric
            {
                get => GetInstanceProperty<K8s.IMetricIdentifierV2>()!;
            }

            /// <summary>target specifies the target value for the given metric.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.ObjectMetricSource#target
            /// </remarks>
            [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"k8s.MetricTargetV2\"}")]
            public K8s.IMetricTargetV2 Target
            {
                get => GetInstanceProperty<K8s.IMetricTargetV2>()!;
            }
        }
    }
}
