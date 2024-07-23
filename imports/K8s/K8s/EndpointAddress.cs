using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>EndpointAddress is a tuple that describes single IP address.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.EndpointAddress
    /// </remarks>
    [JsiiByValue(fqn: "k8s.EndpointAddress")]
    public class EndpointAddress : K8s.IEndpointAddress
    {
        /// <summary>The IP of this endpoint.</summary>
        /// <remarks>
        /// May not be loopback (127.0.0.0/8 or ::1), link-local (169.254.0.0/16 or fe80::/10), or link-local multicast (224.0.0.0/24 or ff02::/16).
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EndpointAddress#ip
        /// </remarks>
        [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}")]
        public string Ip
        {
            get;
            set;
        }

        /// <summary>The Hostname of this endpoint.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EndpointAddress#hostname
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Hostname
        {
            get;
            set;
        }

        /// <summary>Optional: Node hosting this endpoint.</summary>
        /// <remarks>
        /// This can be used to determine endpoints local to a node.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EndpointAddress#nodeName
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nodeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NodeName
        {
            get;
            set;
        }

        /// <summary>Reference to object providing the endpoint.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EndpointAddress#targetRef
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "targetRef", typeJson: "{\"fqn\":\"k8s.ObjectReference\"}", isOptional: true)]
        public K8s.IObjectReference? TargetRef
        {
            get;
            set;
        }
    }
}
