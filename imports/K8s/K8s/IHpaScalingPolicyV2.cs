using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>HPAScalingPolicy is a single policy which must hold true for a specified past interval.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.HPAScalingPolicy
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IHpaScalingPolicyV2), fullyQualifiedName: "k8s.HpaScalingPolicyV2")]
    public interface IHpaScalingPolicyV2
    {
        /// <summary>periodSeconds specifies the window of time for which the policy should hold true.</summary>
        /// <remarks>
        /// PeriodSeconds must be greater than zero and less than or equal to 1800 (30 min).
        ///
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.HPAScalingPolicy#periodSeconds
        /// </remarks>
        [JsiiProperty(name: "periodSeconds", typeJson: "{\"primitive\":\"number\"}")]
        double PeriodSeconds
        {
            get;
        }

        /// <summary>type is used to specify the scaling policy.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.HPAScalingPolicy#type
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>value contains the amount of change which is permitted by the policy.</summary>
        /// <remarks>
        /// It must be greater than zero
        ///
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.HPAScalingPolicy#value
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}")]
        double Value
        {
            get;
        }

        /// <summary>HPAScalingPolicy is a single policy which must hold true for a specified past interval.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.HPAScalingPolicy
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IHpaScalingPolicyV2), fullyQualifiedName: "k8s.HpaScalingPolicyV2")]
        internal sealed class _Proxy : DeputyBase, K8s.IHpaScalingPolicyV2
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>periodSeconds specifies the window of time for which the policy should hold true.</summary>
            /// <remarks>
            /// PeriodSeconds must be greater than zero and less than or equal to 1800 (30 min).
            ///
            /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.HPAScalingPolicy#periodSeconds
            /// </remarks>
            [JsiiProperty(name: "periodSeconds", typeJson: "{\"primitive\":\"number\"}")]
            public double PeriodSeconds
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>type is used to specify the scaling policy.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.HPAScalingPolicy#type
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>value contains the amount of change which is permitted by the policy.</summary>
            /// <remarks>
            /// It must be greater than zero
            ///
            /// <strong>Schema</strong>: io.k8s.api.autoscaling.v2.HPAScalingPolicy#value
            /// </remarks>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}")]
            public double Value
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
