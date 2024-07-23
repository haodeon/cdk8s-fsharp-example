using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>EndpointConditions represents the current condition of an endpoint.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.discovery.v1.EndpointConditions
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IEndpointConditions), fullyQualifiedName: "k8s.EndpointConditions")]
    public interface IEndpointConditions
    {
        /// <summary>ready indicates that this endpoint is prepared to receive traffic, according to whatever system is managing the endpoint.</summary>
        /// <remarks>
        /// A nil value indicates an unknown state. In most cases consumers should interpret this unknown state as ready. For compatibility reasons, ready should never be "true" for terminating endpoints, except when the normal readiness behavior is being explicitly overridden, for example when the associated Service has set the publishNotReadyAddresses flag.
        ///
        /// <strong>Schema</strong>: io.k8s.api.discovery.v1.EndpointConditions#ready
        /// </remarks>
        [JsiiProperty(name: "ready", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? Ready
        {
            get
            {
                return null;
            }
        }

        /// <summary>serving is identical to ready except that it is set regardless of the terminating state of endpoints.</summary>
        /// <remarks>
        /// This condition should be set to true for a ready endpoint that is terminating. If nil, consumers should defer to the ready condition.
        ///
        /// <strong>Schema</strong>: io.k8s.api.discovery.v1.EndpointConditions#serving
        /// </remarks>
        [JsiiProperty(name: "serving", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? Serving
        {
            get
            {
                return null;
            }
        }

        /// <summary>terminating indicates that this endpoint is terminating.</summary>
        /// <remarks>
        /// A nil value indicates an unknown state. Consumers should interpret this unknown state to mean that the endpoint is not terminating.
        ///
        /// <strong>Schema</strong>: io.k8s.api.discovery.v1.EndpointConditions#terminating
        /// </remarks>
        [JsiiProperty(name: "terminating", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? Terminating
        {
            get
            {
                return null;
            }
        }

        /// <summary>EndpointConditions represents the current condition of an endpoint.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.discovery.v1.EndpointConditions
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IEndpointConditions), fullyQualifiedName: "k8s.EndpointConditions")]
        internal sealed class _Proxy : DeputyBase, K8s.IEndpointConditions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ready indicates that this endpoint is prepared to receive traffic, according to whatever system is managing the endpoint.</summary>
            /// <remarks>
            /// A nil value indicates an unknown state. In most cases consumers should interpret this unknown state as ready. For compatibility reasons, ready should never be "true" for terminating endpoints, except when the normal readiness behavior is being explicitly overridden, for example when the associated Service has set the publishNotReadyAddresses flag.
            ///
            /// <strong>Schema</strong>: io.k8s.api.discovery.v1.EndpointConditions#ready
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ready", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? Ready
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>serving is identical to ready except that it is set regardless of the terminating state of endpoints.</summary>
            /// <remarks>
            /// This condition should be set to true for a ready endpoint that is terminating. If nil, consumers should defer to the ready condition.
            ///
            /// <strong>Schema</strong>: io.k8s.api.discovery.v1.EndpointConditions#serving
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serving", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? Serving
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>terminating indicates that this endpoint is terminating.</summary>
            /// <remarks>
            /// A nil value indicates an unknown state. Consumers should interpret this unknown state to mean that the endpoint is not terminating.
            ///
            /// <strong>Schema</strong>: io.k8s.api.discovery.v1.EndpointConditions#terminating
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "terminating", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? Terminating
            {
                get => GetInstanceProperty<bool?>();
            }
        }
    }
}
