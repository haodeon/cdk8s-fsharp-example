using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>LimitResponse defines how to handle requests that can not be executed right now.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.LimitResponse
    /// </remarks>
    [JsiiInterface(nativeType: typeof(ILimitResponseV1Beta3), fullyQualifiedName: "k8s.LimitResponseV1Beta3")]
    public interface ILimitResponseV1Beta3
    {
        /// <summary>`type` is "Queue" or "Reject".</summary>
        /// <remarks>
        /// "Queue" means that requests that can not be executed upon arrival are held in a queue until they can be executed or a queuing limit is reached. "Reject" means that requests that can not be executed upon arrival are rejected. Required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.LimitResponse#type
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>`queuing` holds the configuration parameters for queuing.</summary>
        /// <remarks>
        /// This field may be non-empty only if <c>type</c> is <c>"Queue"</c>.
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.LimitResponse#queuing
        /// </remarks>
        [JsiiProperty(name: "queuing", typeJson: "{\"fqn\":\"k8s.QueuingConfigurationV1Beta3\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IQueuingConfigurationV1Beta3? Queuing
        {
            get
            {
                return null;
            }
        }

        /// <summary>LimitResponse defines how to handle requests that can not be executed right now.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.LimitResponse
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(ILimitResponseV1Beta3), fullyQualifiedName: "k8s.LimitResponseV1Beta3")]
        internal sealed class _Proxy : DeputyBase, K8s.ILimitResponseV1Beta3
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>`type` is "Queue" or "Reject".</summary>
            /// <remarks>
            /// "Queue" means that requests that can not be executed upon arrival are held in a queue until they can be executed or a queuing limit is reached. "Reject" means that requests that can not be executed upon arrival are rejected. Required.
            ///
            /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.LimitResponse#type
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>`queuing` holds the configuration parameters for queuing.</summary>
            /// <remarks>
            /// This field may be non-empty only if <c>type</c> is <c>"Queue"</c>.
            ///
            /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.LimitResponse#queuing
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queuing", typeJson: "{\"fqn\":\"k8s.QueuingConfigurationV1Beta3\"}", isOptional: true)]
            public K8s.IQueuingConfigurationV1Beta3? Queuing
            {
                get => GetInstanceProperty<K8s.IQueuingConfigurationV1Beta3?>();
            }
        }
    }
}
