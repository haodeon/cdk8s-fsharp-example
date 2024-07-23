using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>IngressTLS describes the transport layer security associated with an ingress.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressTLS
    /// </remarks>
    [JsiiByValue(fqn: "k8s.IngressTls")]
    public class IngressTls : K8s.IIngressTls
    {
        /// <summary>hosts is a list of hosts included in the TLS certificate.</summary>
        /// <remarks>
        /// The values in this list must match the name/s used in the tlsSecret. Defaults to the wildcard host setting for the loadbalancer controller fulfilling this Ingress, if left unspecified.
        ///
        /// <strong>Default</strong>: the wildcard host setting for the loadbalancer controller fulfilling this Ingress, if left unspecified.
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressTLS#hosts
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hosts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Hosts
        {
            get;
            set;
        }

        /// <summary>secretName is the name of the secret used to terminate TLS traffic on port 443.</summary>
        /// <remarks>
        /// Field is left optional to allow TLS routing based on SNI hostname alone. If the SNI host in a listener conflicts with the "Host" header field used by an IngressRule, the SNI host is used for termination and value of the "Host" header is used for routing.
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressTLS#secretName
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secretName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecretName
        {
            get;
            set;
        }
    }
}
