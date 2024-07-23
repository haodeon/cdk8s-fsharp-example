using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>IngressTLS describes the transport layer security associated with an ingress.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressTLS
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IIngressTls), fullyQualifiedName: "k8s.IngressTls")]
    public interface IIngressTls
    {
        /// <summary>hosts is a list of hosts included in the TLS certificate.</summary>
        /// <remarks>
        /// The values in this list must match the name/s used in the tlsSecret. Defaults to the wildcard host setting for the loadbalancer controller fulfilling this Ingress, if left unspecified.
        ///
        /// <strong>Default</strong>: the wildcard host setting for the loadbalancer controller fulfilling this Ingress, if left unspecified.
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressTLS#hosts
        /// </remarks>
        [JsiiProperty(name: "hosts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Hosts
        {
            get
            {
                return null;
            }
        }

        /// <summary>secretName is the name of the secret used to terminate TLS traffic on port 443.</summary>
        /// <remarks>
        /// Field is left optional to allow TLS routing based on SNI hostname alone. If the SNI host in a listener conflicts with the "Host" header field used by an IngressRule, the SNI host is used for termination and value of the "Host" header is used for routing.
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressTLS#secretName
        /// </remarks>
        [JsiiProperty(name: "secretName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecretName
        {
            get
            {
                return null;
            }
        }

        /// <summary>IngressTLS describes the transport layer security associated with an ingress.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressTLS
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IIngressTls), fullyQualifiedName: "k8s.IngressTls")]
        internal sealed class _Proxy : DeputyBase, K8s.IIngressTls
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

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
                get => GetInstanceProperty<string[]?>();
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
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
