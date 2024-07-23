using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>EndpointPort is a tuple that describes a single port.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.EndpointPort
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IEndpointPort), fullyQualifiedName: "k8s.EndpointPort")]
    public interface IEndpointPort
    {
        /// <summary>The port number of the endpoint.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EndpointPort#port
        /// </remarks>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        double Port
        {
            get;
        }

        /// <summary>The application protocol for this port.</summary>
        /// <remarks>
        /// This is used as a hint for implementations to offer richer behavior for protocols that they understand. This field follows standard Kubernetes label syntax. Valid values are either:
        ///
        /// <list type="bullet">
        /// <description>Un-prefixed protocol names - reserved for IANA standard service names (as per RFC-6335 and https://www.iana.org/assignments/service-names).</description>
        /// <description>Kubernetes-defined prefixed names:</description>
        /// <description>'kubernetes.io/h2c' - HTTP/2 prior knowledge over cleartext as described in https://www.rfc-editor.org/rfc/rfc9113.html#name-starting-http-2-with-prior-</description>
        /// <description>'kubernetes.io/ws'  - WebSocket over cleartext as described in https://www.rfc-editor.org/rfc/rfc6455</description>
        /// <description>'kubernetes.io/wss' - WebSocket over TLS as described in https://www.rfc-editor.org/rfc/rfc6455</description>
        /// <description>Other protocols should use implementation-defined prefixed names such as mycompany.com/my-custom-protocol.</description>
        /// </list>
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EndpointPort#appProtocol
        /// </remarks>
        [JsiiProperty(name: "appProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AppProtocol
        {
            get
            {
                return null;
            }
        }

        /// <summary>The name of this port.</summary>
        /// <remarks>
        /// This must match the 'name' field in the corresponding ServicePort. Must be a DNS_LABEL. Optional only if one port is defined.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EndpointPort#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>The IP protocol for this port.</summary>
        /// <remarks>
        /// Must be UDP, TCP, or SCTP. Default is TCP.
        ///
        /// <strong>Default</strong>: TCP.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EndpointPort#protocol
        /// </remarks>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Protocol
        {
            get
            {
                return null;
            }
        }

        /// <summary>EndpointPort is a tuple that describes a single port.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EndpointPort
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IEndpointPort), fullyQualifiedName: "k8s.EndpointPort")]
        internal sealed class _Proxy : DeputyBase, K8s.IEndpointPort
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The port number of the endpoint.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.EndpointPort#port
            /// </remarks>
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
            public double Port
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>The application protocol for this port.</summary>
            /// <remarks>
            /// This is used as a hint for implementations to offer richer behavior for protocols that they understand. This field follows standard Kubernetes label syntax. Valid values are either:
            ///
            /// <list type="bullet">
            /// <description>Un-prefixed protocol names - reserved for IANA standard service names (as per RFC-6335 and https://www.iana.org/assignments/service-names).</description>
            /// <description>Kubernetes-defined prefixed names:</description>
            /// <description>'kubernetes.io/h2c' - HTTP/2 prior knowledge over cleartext as described in https://www.rfc-editor.org/rfc/rfc9113.html#name-starting-http-2-with-prior-</description>
            /// <description>'kubernetes.io/ws'  - WebSocket over cleartext as described in https://www.rfc-editor.org/rfc/rfc6455</description>
            /// <description>'kubernetes.io/wss' - WebSocket over TLS as described in https://www.rfc-editor.org/rfc/rfc6455</description>
            /// <description>Other protocols should use implementation-defined prefixed names such as mycompany.com/my-custom-protocol.</description>
            /// </list>
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.EndpointPort#appProtocol
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "appProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AppProtocol
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The name of this port.</summary>
            /// <remarks>
            /// This must match the 'name' field in the corresponding ServicePort. Must be a DNS_LABEL. Optional only if one port is defined.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.EndpointPort#name
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The IP protocol for this port.</summary>
            /// <remarks>
            /// Must be UDP, TCP, or SCTP. Default is TCP.
            ///
            /// <strong>Default</strong>: TCP.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.EndpointPort#protocol
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Protocol
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
