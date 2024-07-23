using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>NetworkPolicyPort describes a port to allow traffic on.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.networking.v1.NetworkPolicyPort
    /// </remarks>
    [JsiiByValue(fqn: "k8s.NetworkPolicyPort")]
    public class NetworkPolicyPort : K8s.INetworkPolicyPort
    {
        /// <summary>endPort indicates that the range of ports from port to endPort if set, inclusive, should be allowed by the policy.</summary>
        /// <remarks>
        /// This field cannot be defined if the port field is not defined or if the port field is defined as a named (string) port. The endPort must be equal or greater than port.
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.NetworkPolicyPort#endPort
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "endPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? EndPort
        {
            get;
            set;
        }

        /// <summary>port represents the port on the given protocol.</summary>
        /// <remarks>
        /// This can either be a numerical or named port on a pod. If this field is not provided, this matches all port names and numbers. If present, only traffic on the specified protocol AND port will be matched.
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.NetworkPolicyPort#port
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"fqn\":\"k8s.IntOrString\"}", isOptional: true)]
        public K8s.IntOrString? Port
        {
            get;
            set;
        }

        /// <summary>protocol represents the protocol (TCP, UDP, or SCTP) which traffic must match.</summary>
        /// <remarks>
        /// If not specified, this field defaults to TCP.
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.NetworkPolicyPort#protocol
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
