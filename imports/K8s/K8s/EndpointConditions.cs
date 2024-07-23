using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>EndpointConditions represents the current condition of an endpoint.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.discovery.v1.EndpointConditions
    /// </remarks>
    [JsiiByValue(fqn: "k8s.EndpointConditions")]
    public class EndpointConditions : K8s.IEndpointConditions
    {
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
            get;
            set;
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
            get;
            set;
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
            get;
            set;
        }
    }
}
