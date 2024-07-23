using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ServicePort contains information on service's port.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ServicePort
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IServicePort), fullyQualifiedName: "k8s.ServicePort")]
    public interface IServicePort
    {
        /// <summary>The port that will be exposed by this service.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServicePort#port
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
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServicePort#appProtocol
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

        /// <summary>The name of this port within the service.</summary>
        /// <remarks>
        /// This must be a DNS_LABEL. All ports within a ServiceSpec must have unique names. When considering the endpoints for a Service, this must match the 'name' field in the EndpointPort. Optional if only one ServicePort is defined on this service.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServicePort#name
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

        /// <summary>The port on each node on which this service is exposed when type is NodePort or LoadBalancer.</summary>
        /// <remarks>
        /// Usually assigned by the system. If a value is specified, in-range, and not in use it will be used, otherwise the operation will fail.  If not specified, a port will be allocated if this Service requires one.  If this field is specified when creating a Service which does not need it, creation will fail. This field will be wiped when updating a Service to no longer need it (e.g. changing type from NodePort to ClusterIP). More info: https://kubernetes.io/docs/concepts/services-networking/service/#type-nodeport
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServicePort#nodePort
        /// </remarks>
        [JsiiProperty(name: "nodePort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? NodePort
        {
            get
            {
                return null;
            }
        }

        /// <summary>The IP protocol for this port.</summary>
        /// <remarks>
        /// Supports "TCP", "UDP", and "SCTP". Default is TCP.
        ///
        /// <strong>Default</strong>: TCP.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServicePort#protocol
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

        /// <summary>Number or name of the port to access on the pods targeted by the service.</summary>
        /// <remarks>
        /// Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME. If this is a string, it will be looked up as a named port in the target Pod's container ports. If this is not specified, the value of the 'port' field is used (an identity map). This field is ignored for services with clusterIP=None, and should be omitted or set equal to the 'port' field. More info: https://kubernetes.io/docs/concepts/services-networking/service/#defining-a-service
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServicePort#targetPort
        /// </remarks>
        [JsiiProperty(name: "targetPort", typeJson: "{\"fqn\":\"k8s.IntOrString\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IntOrString? TargetPort
        {
            get
            {
                return null;
            }
        }

        /// <summary>ServicePort contains information on service's port.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServicePort
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IServicePort), fullyQualifiedName: "k8s.ServicePort")]
        internal sealed class _Proxy : DeputyBase, K8s.IServicePort
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The port that will be exposed by this service.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ServicePort#port
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
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ServicePort#appProtocol
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "appProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AppProtocol
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The name of this port within the service.</summary>
            /// <remarks>
            /// This must be a DNS_LABEL. All ports within a ServiceSpec must have unique names. When considering the endpoints for a Service, this must match the 'name' field in the EndpointPort. Optional if only one ServicePort is defined on this service.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ServicePort#name
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The port on each node on which this service is exposed when type is NodePort or LoadBalancer.</summary>
            /// <remarks>
            /// Usually assigned by the system. If a value is specified, in-range, and not in use it will be used, otherwise the operation will fail.  If not specified, a port will be allocated if this Service requires one.  If this field is specified when creating a Service which does not need it, creation will fail. This field will be wiped when updating a Service to no longer need it (e.g. changing type from NodePort to ClusterIP). More info: https://kubernetes.io/docs/concepts/services-networking/service/#type-nodeport
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ServicePort#nodePort
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nodePort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? NodePort
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The IP protocol for this port.</summary>
            /// <remarks>
            /// Supports "TCP", "UDP", and "SCTP". Default is TCP.
            ///
            /// <strong>Default</strong>: TCP.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ServicePort#protocol
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Protocol
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Number or name of the port to access on the pods targeted by the service.</summary>
            /// <remarks>
            /// Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME. If this is a string, it will be looked up as a named port in the target Pod's container ports. If this is not specified, the value of the 'port' field is used (an identity map). This field is ignored for services with clusterIP=None, and should be omitted or set equal to the 'port' field. More info: https://kubernetes.io/docs/concepts/services-networking/service/#defining-a-service
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ServicePort#targetPort
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "targetPort", typeJson: "{\"fqn\":\"k8s.IntOrString\"}", isOptional: true)]
            public K8s.IntOrString? TargetPort
            {
                get => GetInstanceProperty<K8s.IntOrString?>();
            }
        }
    }
}
