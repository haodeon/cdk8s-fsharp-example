using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>IngressRule represents the rules mapping the paths under a specified host to the related backend services.</summary>
    /// <remarks>
    /// Incoming requests are first evaluated for a host match, then routed to the backend associated with the matching IngressRuleValue.
    ///
    /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressRule
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IIngressRule), fullyQualifiedName: "k8s.IngressRule")]
    public interface IIngressRule
    {
        /// <summary>host is the fully qualified domain name of a network host, as defined by RFC 3986.</summary>
        /// <remarks>
        /// Note the following deviations from the "host" part of the URI as defined in RFC 3986: 1. IPs are not allowed. Currently an IngressRuleValue can only apply to
        /// the IP in the Spec of the parent Ingress.
        /// 2. The <c>:</c> delimiter is not respected because ports are not allowed.
        /// Currently the port of an Ingress is implicitly :80 for http and
        /// :443 for https.
        /// Both these may change in the future. Incoming requests are matched against the host before the IngressRuleValue. If the host is unspecified, the Ingress routes all traffic based on the specified IngressRuleValue.
        ///
        /// host can be "precise" which is a domain name without the terminating dot of a network host (e.g. "foo.bar.com") or "wildcard", which is a domain name prefixed with a single wildcard label (e.g. "<em>.foo.com"). The wildcard character '</em>' must appear by itself as the first DNS label and matches only a single label. You cannot have a wildcard label by itself (e.g. Host == "*"). Requests will be matched against the Host field in the following way: 1. If host is precise, the request matches this rule if the http host header is equal to Host. 2. If host is a wildcard, then the request matches this rule if the http host header is to equal to the suffix (removing the first label) of the wildcard rule.
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressRule#host
        /// </remarks>
        [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Host
        {
            get
            {
                return null;
            }
        }

        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressRule#http
        /// </remarks>
        [JsiiProperty(name: "http", typeJson: "{\"fqn\":\"k8s.HttpIngressRuleValue\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IHttpIngressRuleValue? Http
        {
            get
            {
                return null;
            }
        }

        /// <summary>IngressRule represents the rules mapping the paths under a specified host to the related backend services.</summary>
        /// <remarks>
        /// Incoming requests are first evaluated for a host match, then routed to the backend associated with the matching IngressRuleValue.
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressRule
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IIngressRule), fullyQualifiedName: "k8s.IngressRule")]
        internal sealed class _Proxy : DeputyBase, K8s.IIngressRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>host is the fully qualified domain name of a network host, as defined by RFC 3986.</summary>
            /// <remarks>
            /// Note the following deviations from the "host" part of the URI as defined in RFC 3986: 1. IPs are not allowed. Currently an IngressRuleValue can only apply to
            /// the IP in the Spec of the parent Ingress.
            /// 2. The <c>:</c> delimiter is not respected because ports are not allowed.
            /// Currently the port of an Ingress is implicitly :80 for http and
            /// :443 for https.
            /// Both these may change in the future. Incoming requests are matched against the host before the IngressRuleValue. If the host is unspecified, the Ingress routes all traffic based on the specified IngressRuleValue.
            ///
            /// host can be "precise" which is a domain name without the terminating dot of a network host (e.g. "foo.bar.com") or "wildcard", which is a domain name prefixed with a single wildcard label (e.g. "<em>.foo.com"). The wildcard character '</em>' must appear by itself as the first DNS label and matches only a single label. You cannot have a wildcard label by itself (e.g. Host == "*"). Requests will be matched against the Host field in the following way: 1. If host is precise, the request matches this rule if the http host header is equal to Host. 2. If host is a wildcard, then the request matches this rule if the http host header is to equal to the suffix (removing the first label) of the wildcard rule.
            ///
            /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressRule#host
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Host
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressRule#http
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "http", typeJson: "{\"fqn\":\"k8s.HttpIngressRuleValue\"}", isOptional: true)]
            public K8s.IHttpIngressRuleValue? Http
            {
                get => GetInstanceProperty<K8s.IHttpIngressRuleValue?>();
            }
        }
    }
}
