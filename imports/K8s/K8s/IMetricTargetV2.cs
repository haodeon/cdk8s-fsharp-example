using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>MetricTarget defines the target value, average value, or average utilization of a specific metric.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.MetricTarget
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IMetricTargetV2), fullyQualifiedName: "k8s.MetricTargetV2")]
    public interface IMetricTargetV2
    {
        /// <summary>type represents whether the metric type is Utilization, Value, or AverageValue.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.MetricTarget#type
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>averageUtilization is the target value of the average of the resource metric across all relevant pods, represented as a percentage of the requested value of the resource for the pods.</summary>
        /// <remarks>
        /// Currently only valid for Resource metric source type
        ///
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.MetricTarget#averageUtilization
        /// </remarks>
        [JsiiProperty(name: "averageUtilization", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AverageUtilization
        {
            get
            {
                return null;
            }
        }

        /// <summary>averageValue is the target value of the average of the metric across all relevant pods (as a quantity).</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.MetricTarget#averageValue
        /// </remarks>
        [JsiiProperty(name: "averageValue", typeJson: "{\"fqn\":\"k8s.Quantity\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.Quantity? AverageValue
        {
            get
            {
                return null;
            }
        }

        /// <summary>value is the target value of the metric (as a quantity).</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.MetricTarget#value
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"fqn\":\"k8s.Quantity\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.Quantity? Value
        {
            get
            {
                return null;
            }
        }

        /// <summary>MetricTarget defines the target value, average value, or average utilization of a specific metric.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.MetricTarget
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IMetricTargetV2), fullyQualifiedName: "k8s.MetricTargetV2")]
        internal sealed class _Proxy : DeputyBase, K8s.IMetricTargetV2
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>type represents whether the metric type is Utilization, Value, or AverageValue.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.MetricTarget#type
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>averageUtilization is the target value of the average of the resource metric across all relevant pods, represented as a percentage of the requested value of the resource for the pods.</summary>
            /// <remarks>
            /// Currently only valid for Resource metric source type
            ///
            /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.MetricTarget#averageUtilization
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "averageUtilization", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AverageUtilization
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>averageValue is the target value of the average of the metric across all relevant pods (as a quantity).</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.MetricTarget#averageValue
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "averageValue", typeJson: "{\"fqn\":\"k8s.Quantity\"}", isOptional: true)]
            public K8s.Quantity? AverageValue
            {
                get => GetInstanceProperty<K8s.Quantity?>();
            }

            /// <summary>value is the target value of the metric (as a quantity).</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.MetricTarget#value
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "value", typeJson: "{\"fqn\":\"k8s.Quantity\"}", isOptional: true)]
            public K8s.Quantity? Value
            {
                get => GetInstanceProperty<K8s.Quantity?>();
            }
        }
    }
}
