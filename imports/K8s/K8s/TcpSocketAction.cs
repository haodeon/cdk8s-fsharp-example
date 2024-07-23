using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>TCPSocketAction describes an action based on opening a socket.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.TCPSocketAction
    /// </remarks>
    [JsiiByValue(fqn: "k8s.TcpSocketAction")]
    public class TcpSocketAction : K8s.ITcpSocketAction
    {
        /// <summary>Number or name of the port to access on the container.</summary>
        /// <remarks>
        /// Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.TCPSocketAction#port
        /// </remarks>
        [JsiiProperty(name: "port", typeJson: "{\"fqn\":\"k8s.IntOrString\"}")]
        public K8s.IntOrString Port
        {
            get;
            set;
        }

        /// <summary>Optional: Host name to connect to, defaults to the pod IP.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.TCPSocketAction#host
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Host
        {
            get;
            set;
        }
    }
}
