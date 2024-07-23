using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>LimitResponse defines how to handle requests that can not be executed right now.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.LimitResponse
    /// </remarks>
    [JsiiInterface(nativeType: typeof(ILimitResponse), fullyQualifiedName: "k8s.LimitResponse")]
    public interface ILimitResponse
    {
        /// <summary>`type` is "Queue" or "Reject".</summary>
        /// <remarks>
        /// "Queue" means that requests that can not be executed upon arrival are held in a queue until they can be executed or a queuing limit is reached. "Reject" means that requests that can not be executed upon arrival are rejected. Required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.LimitResponse#type
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
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.LimitResponse#queuing
        /// </remarks>
        [JsiiProperty(name: "queuing", typeJson: "{\"fqn\":\"k8s.QueuingConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IQueuingConfiguration? Queuing
        {
            get
            {
                return null;
            }
        }

        /// <summary>LimitResponse defines how to handle requests that can not be executed right now.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.LimitResponse
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(ILimitResponse), fullyQualifiedName: "k8s.LimitResponse")]
        internal sealed class _Proxy : DeputyBase, K8s.ILimitResponse
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>`type` is "Queue" or "Reject".</summary>
            /// <remarks>
            /// "Queue" means that requests that can not be executed upon arrival are held in a queue until they can be executed or a queuing limit is reached. "Reject" means that requests that can not be executed upon arrival are rejected. Required.
            ///
            /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.LimitResponse#type
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
            /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.LimitResponse#queuing
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queuing", typeJson: "{\"fqn\":\"k8s.QueuingConfiguration\"}", isOptional: true)]
            public K8s.IQueuingConfiguration? Queuing
            {
                get => GetInstanceProperty<K8s.IQueuingConfiguration?>();
            }
        }
    }
}
