using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>RollingUpdateStatefulSetStrategy is used to communicate parameter for RollingUpdateStatefulSetStrategyType.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.apps.v1.RollingUpdateStatefulSetStrategy
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IRollingUpdateStatefulSetStrategy), fullyQualifiedName: "k8s.RollingUpdateStatefulSetStrategy")]
    public interface IRollingUpdateStatefulSetStrategy
    {
        /// <summary>The maximum number of pods that can be unavailable during the update.</summary>
        /// <remarks>
        /// Value can be an absolute number (ex: 5) or a percentage of desired pods (ex: 10%). Absolute number is calculated from percentage by rounding up. This can not be 0. Defaults to 1. This field is alpha-level and is only honored by servers that enable the MaxUnavailableStatefulSet feature. The field applies to all pods in the range 0 to Replicas-1. That means if there is any unavailable pod in the range 0 to Replicas-1, it will be counted towards MaxUnavailable.
        ///
        /// <strong>Default</strong>: 1. This field is alpha-level and is only honored by servers that enable the MaxUnavailableStatefulSet feature. The field applies to all pods in the range 0 to Replicas-1. That means if there is any unavailable pod in the range 0 to Replicas-1, it will be counted towards MaxUnavailable.
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.RollingUpdateStatefulSetStrategy#maxUnavailable
        /// </remarks>
        [JsiiProperty(name: "maxUnavailable", typeJson: "{\"fqn\":\"k8s.IntOrString\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IntOrString? MaxUnavailable
        {
            get
            {
                return null;
            }
        }

        /// <summary>Partition indicates the ordinal at which the StatefulSet should be partitioned for updates.</summary>
        /// <remarks>
        /// During a rolling update, all pods from ordinal Replicas-1 to Partition are updated. All pods from ordinal Partition-1 to 0 remain untouched. This is helpful in being able to do a canary based deployment. The default value is 0.
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.RollingUpdateStatefulSetStrategy#partition
        /// </remarks>
        [JsiiProperty(name: "partition", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Partition
        {
            get
            {
                return null;
            }
        }

        /// <summary>RollingUpdateStatefulSetStrategy is used to communicate parameter for RollingUpdateStatefulSetStrategyType.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.RollingUpdateStatefulSetStrategy
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IRollingUpdateStatefulSetStrategy), fullyQualifiedName: "k8s.RollingUpdateStatefulSetStrategy")]
        internal sealed class _Proxy : DeputyBase, K8s.IRollingUpdateStatefulSetStrategy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The maximum number of pods that can be unavailable during the update.</summary>
            /// <remarks>
            /// Value can be an absolute number (ex: 5) or a percentage of desired pods (ex: 10%). Absolute number is calculated from percentage by rounding up. This can not be 0. Defaults to 1. This field is alpha-level and is only honored by servers that enable the MaxUnavailableStatefulSet feature. The field applies to all pods in the range 0 to Replicas-1. That means if there is any unavailable pod in the range 0 to Replicas-1, it will be counted towards MaxUnavailable.
            ///
            /// <strong>Default</strong>: 1. This field is alpha-level and is only honored by servers that enable the MaxUnavailableStatefulSet feature. The field applies to all pods in the range 0 to Replicas-1. That means if there is any unavailable pod in the range 0 to Replicas-1, it will be counted towards MaxUnavailable.
            ///
            /// <strong>Schema</strong>: io.k8s.api.apps.v1.RollingUpdateStatefulSetStrategy#maxUnavailable
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxUnavailable", typeJson: "{\"fqn\":\"k8s.IntOrString\"}", isOptional: true)]
            public K8s.IntOrString? MaxUnavailable
            {
                get => GetInstanceProperty<K8s.IntOrString?>();
            }

            /// <summary>Partition indicates the ordinal at which the StatefulSet should be partitioned for updates.</summary>
            /// <remarks>
            /// During a rolling update, all pods from ordinal Replicas-1 to Partition are updated. All pods from ordinal Partition-1 to 0 remain untouched. This is helpful in being able to do a canary based deployment. The default value is 0.
            ///
            /// <strong>Schema</strong>: io.k8s.api.apps.v1.RollingUpdateStatefulSetStrategy#partition
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "partition", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Partition
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
