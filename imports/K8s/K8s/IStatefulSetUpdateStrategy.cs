using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>StatefulSetUpdateStrategy indicates the strategy that the StatefulSet controller will use to perform updates.</summary>
    /// <remarks>
    /// It includes any additional parameters necessary to perform the update for the indicated strategy.
    ///
    /// <strong>Schema</strong>: io.k8s.api.apps.v1.StatefulSetUpdateStrategy
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IStatefulSetUpdateStrategy), fullyQualifiedName: "k8s.StatefulSetUpdateStrategy")]
    public interface IStatefulSetUpdateStrategy
    {
        /// <summary>RollingUpdate is used to communicate parameters when Type is RollingUpdateStatefulSetStrategyType.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.StatefulSetUpdateStrategy#rollingUpdate
        /// </remarks>
        [JsiiProperty(name: "rollingUpdate", typeJson: "{\"fqn\":\"k8s.RollingUpdateStatefulSetStrategy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IRollingUpdateStatefulSetStrategy? RollingUpdate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Type indicates the type of the StatefulSetUpdateStrategy.</summary>
        /// <remarks>
        /// Default is RollingUpdate.
        ///
        /// <strong>Default</strong>: RollingUpdate.
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.StatefulSetUpdateStrategy#type
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        /// <summary>StatefulSetUpdateStrategy indicates the strategy that the StatefulSet controller will use to perform updates.</summary>
        /// <remarks>
        /// It includes any additional parameters necessary to perform the update for the indicated strategy.
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.StatefulSetUpdateStrategy
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IStatefulSetUpdateStrategy), fullyQualifiedName: "k8s.StatefulSetUpdateStrategy")]
        internal sealed class _Proxy : DeputyBase, K8s.IStatefulSetUpdateStrategy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>RollingUpdate is used to communicate parameters when Type is RollingUpdateStatefulSetStrategyType.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.apps.v1.StatefulSetUpdateStrategy#rollingUpdate
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rollingUpdate", typeJson: "{\"fqn\":\"k8s.RollingUpdateStatefulSetStrategy\"}", isOptional: true)]
            public K8s.IRollingUpdateStatefulSetStrategy? RollingUpdate
            {
                get => GetInstanceProperty<K8s.IRollingUpdateStatefulSetStrategy?>();
            }

            /// <summary>Type indicates the type of the StatefulSetUpdateStrategy.</summary>
            /// <remarks>
            /// Default is RollingUpdate.
            ///
            /// <strong>Default</strong>: RollingUpdate.
            ///
            /// <strong>Schema</strong>: io.k8s.api.apps.v1.StatefulSetUpdateStrategy#type
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
