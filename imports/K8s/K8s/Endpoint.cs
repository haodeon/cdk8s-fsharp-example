using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>Endpoint represents a single logical "backend" implementing a service.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.discovery.v1.Endpoint
    /// </remarks>
    [JsiiByValue(fqn: "k8s.Endpoint")]
    public class Endpoint : K8s.IEndpoint
    {
        /// <summary>addresses of this endpoint.</summary>
        /// <remarks>
        /// The contents of this field are interpreted according to the corresponding EndpointSlice addressType field. Consumers must handle different types of addresses in the context of their own capabilities. This must contain at least one address but no more than 100. These are all assumed to be fungible and clients may choose to only use the first element. Refer to: https://issue.k8s.io/106267
        ///
        /// <strong>Schema</strong>: io.k8s.api.discovery.v1.Endpoint#addresses
        /// </remarks>
        [JsiiProperty(name: "addresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Addresses
        {
            get;
            set;
        }

        /// <summary>conditions contains information about the current status of the endpoint.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.discovery.v1.Endpoint#conditions
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "conditions", typeJson: "{\"fqn\":\"k8s.EndpointConditions\"}", isOptional: true)]
        public K8s.IEndpointConditions? Conditions
        {
            get;
            set;
        }

        /// <summary>deprecatedTopology contains topology information part of the v1beta1 API.</summary>
        /// <remarks>
        /// This field is deprecated, and will be removed when the v1beta1 API is removed (no sooner than kubernetes v1.24).  While this field can hold values, it is not writable through the v1 API, and any attempts to write to it will be silently ignored. Topology information can be found in the zone and nodeName fields instead.
        ///
        /// <strong>Schema</strong>: io.k8s.api.discovery.v1.Endpoint#deprecatedTopology
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deprecatedTopology", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? DeprecatedTopology
        {
            get;
            set;
        }

        /// <summary>hints contains information associated with how an endpoint should be consumed.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.discovery.v1.Endpoint#hints
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hints", typeJson: "{\"fqn\":\"k8s.EndpointHints\"}", isOptional: true)]
        public K8s.IEndpointHints? Hints
        {
            get;
            set;
        }

        /// <summary>hostname of this endpoint.</summary>
        /// <remarks>
        /// This field may be used by consumers of endpoints to distinguish endpoints from each other (e.g. in DNS names). Multiple endpoints which use the same hostname should be considered fungible (e.g. multiple A values in DNS). Must be lowercase and pass DNS Label (RFC 1123) validation.
        ///
        /// <strong>Schema</strong>: io.k8s.api.discovery.v1.Endpoint#hostname
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Hostname
        {
            get;
            set;
        }

        /// <summary>nodeName represents the name of the Node hosting this endpoint.</summary>
        /// <remarks>
        /// This can be used to determine endpoints local to a Node.
        ///
        /// <strong>Schema</strong>: io.k8s.api.discovery.v1.Endpoint#nodeName
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nodeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NodeName
        {
            get;
            set;
        }

        /// <summary>targetRef is a reference to a Kubernetes object that represents this endpoint.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.discovery.v1.Endpoint#targetRef
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "targetRef", typeJson: "{\"fqn\":\"k8s.ObjectReference\"}", isOptional: true)]
        public K8s.IObjectReference? TargetRef
        {
            get;
            set;
        }

        /// <summary>zone is the name of the Zone this endpoint exists in.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.discovery.v1.Endpoint#zone
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Zone
        {
            get;
            set;
        }
    }
}
