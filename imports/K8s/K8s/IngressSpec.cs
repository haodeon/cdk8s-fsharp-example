using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>IngressSpec describes the Ingress the user wishes to exist.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressSpec
    /// </remarks>
    [JsiiByValue(fqn: "k8s.IngressSpec")]
    public class IngressSpec : K8s.IIngressSpec
    {
        /// <summary>defaultBackend is the backend that should handle requests that don't match any rule.</summary>
        /// <remarks>
        /// If Rules are not specified, DefaultBackend must be specified. If DefaultBackend is not set, the handling of requests that do not match any of the rules will be up to the Ingress controller.
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressSpec#defaultBackend
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "defaultBackend", typeJson: "{\"fqn\":\"k8s.IngressBackend\"}", isOptional: true)]
        public K8s.IIngressBackend? DefaultBackend
        {
            get;
            set;
        }

        /// <summary>ingressClassName is the name of an IngressClass cluster resource.</summary>
        /// <remarks>
        /// Ingress controller implementations use this field to know whether they should be serving this Ingress resource, by a transitive connection (controller -&gt; IngressClass -&gt; Ingress resource). Although the <c>kubernetes.io/ingress.class</c> annotation (simple constant name) was never formally defined, it was widely supported by Ingress controllers to create a direct binding between Ingress controller and Ingress resources. Newly created Ingress resources should prefer using the field. However, even though the annotation is officially deprecated, for backwards compatibility reasons, ingress controllers should still honor that annotation if present.
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressSpec#ingressClassName
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ingressClassName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IngressClassName
        {
            get;
            set;
        }

        /// <summary>rules is a list of host rules used to configure the Ingress.</summary>
        /// <remarks>
        /// If unspecified, or no rule matches, all traffic is sent to the default backend.
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressSpec#rules
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rules", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.IngressRule\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.IIngressRule[]? Rules
        {
            get;
            set;
        }

        /// <summary>tls represents the TLS configuration.</summary>
        /// <remarks>
        /// Currently the Ingress only supports a single TLS port, 443. If multiple members of this list specify different hosts, they will be multiplexed on the same port according to the hostname specified through the SNI TLS extension, if the ingress controller fulfilling the ingress supports SNI.
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressSpec#tls
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tls", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.IngressTls\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.IIngressTls[]? Tls
        {
            get;
            set;
        }
    }
}
