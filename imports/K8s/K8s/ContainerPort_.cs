using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>ContainerPort represents a network port in a single container.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ContainerPort
    /// </remarks>
    [JsiiByValue(fqn: "k8s.ContainerPort")]
    public class ContainerPort_ : K8s.IContainerPort
    {
        /// <summary>Number of port to expose on the pod's IP address.</summary>
        /// <remarks>
        /// This must be a valid port number, 0 &lt; x &lt; 65536.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ContainerPort#containerPort
        /// </remarks>
        [JsiiProperty(name: "containerPort", typeJson: "{\"primitive\":\"number\"}")]
        public double ContainerPort
        {
            get;
            set;
        }

        /// <summary>What host IP to bind the external port to.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ContainerPort#hostIP
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hostIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HostIp
        {
            get;
            set;
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
            get;
            set;
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
            get;
            set;
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
            get;
            set;
        }
    }
}
