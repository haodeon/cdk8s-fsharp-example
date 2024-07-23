using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ContainerPort represents a network port in a single container.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ContainerPort
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IContainerPort), fullyQualifiedName: "k8s.ContainerPort")]
    public interface IContainerPort
    {
        /// <summary>Number of port to expose on the pod's IP address.</summary>
        /// <remarks>
        /// This must be a valid port number, 0 &lt; x &lt; 65536.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ContainerPort#containerPort
        /// </remarks>
        [JsiiProperty(name: "containerPort", typeJson: "{\"primitive\":\"number\"}")]
        double ContainerPort
        {
            get;
        }

        /// <summary>What host IP to bind the external port to.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ContainerPort#hostIP
        /// </remarks>
        [JsiiProperty(name: "hostIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HostIp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Number of port to expose on the host.</summary>
        /// <remarks>
        /// If specified, this must be a valid port number, 0 &lt; x &lt; 65536. If HostNetwork is specified, this must match ContainerPort. Most containers do not need this.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ContainerPort#hostPort
        /// </remarks>
        [JsiiProperty(name: "hostPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? HostPort
        {
            get
            {
                return null;
            }
        }

        /// <summary>If specified, this must be an IANA_SVC_NAME and unique within the pod.</summary>
        /// <remarks>
        /// Each named port in a pod must have a unique name. Name for the port that can be referred to by services.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ContainerPort#name
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

        /// <summary>Protocol for port.</summary>
        /// <remarks>
        /// Must be UDP, TCP, or SCTP. Defaults to "TCP".
        ///
        /// <strong>Default</strong>: TCP".
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ContainerPort#protocol
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

        /// <summary>ContainerPort represents a network port in a single container.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ContainerPort
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IContainerPort), fullyQualifiedName: "k8s.ContainerPort")]
        internal sealed class _Proxy : DeputyBase, K8s.IContainerPort
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Number of port to expose on the pod's IP address.</summary>
            /// <remarks>
            /// This must be a valid port number, 0 &lt; x &lt; 65536.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ContainerPort#containerPort
            /// </remarks>
            [JsiiProperty(name: "containerPort", typeJson: "{\"primitive\":\"number\"}")]
            public double ContainerPort
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>What host IP to bind the external port to.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ContainerPort#hostIP
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hostIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HostIp
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Number of port to expose on the host.</summary>
            /// <remarks>
            /// If specified, this must be a valid port number, 0 &lt; x &lt; 65536. If HostNetwork is specified, this must match ContainerPort. Most containers do not need this.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ContainerPort#hostPort
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hostPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HostPort
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>If specified, this must be an IANA_SVC_NAME and unique within the pod.</summary>
            /// <remarks>
            /// Each named port in a pod must have a unique name. Name for the port that can be referred to by services.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ContainerPort#name
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Protocol for port.</summary>
            /// <remarks>
            /// Must be UDP, TCP, or SCTP. Defaults to "TCP".
            ///
            /// <strong>Default</strong>: TCP".
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ContainerPort#protocol
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
