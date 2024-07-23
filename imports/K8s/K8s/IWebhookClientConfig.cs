using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>WebhookClientConfig contains the information to make a TLS connection with the webhook.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.WebhookClientConfig
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IWebhookClientConfig), fullyQualifiedName: "k8s.WebhookClientConfig")]
    public interface IWebhookClientConfig
    {
        /// <summary>`caBundle` is a PEM encoded CA bundle which will be used to validate the webhook's server certificate.</summary>
        /// <remarks>
        /// If unspecified, system trust roots on the apiserver are used.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.WebhookClientConfig#caBundle
        /// </remarks>
        [JsiiProperty(name: "caBundle", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CaBundle
        {
            get
            {
                return null;
            }
        }

        /// <summary>`service` is a reference to the service for this webhook. Either `service` or `url` must be specified.</summary>
        /// <remarks>
        /// If the webhook is running within the cluster, then you should use <c>service</c>.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.WebhookClientConfig#service
        /// </remarks>
        [JsiiProperty(name: "service", typeJson: "{\"fqn\":\"k8s.ServiceReference\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IServiceReference? Service
        {
            get
            {
                return null;
            }
        }

        /// <summary>`url` gives the location of the webhook, in standard URL form (`scheme://host:port/path`).</summary>
        /// <remarks>
        /// Exactly one of <c>url</c> or <c>service</c> must be specified.
        ///
        /// The <c>host</c> should not refer to a service running in the cluster; use the <c>service</c> field instead. The host might be resolved via external DNS in some apiservers (e.g., <c>kube-apiserver</c> cannot resolve in-cluster DNS as that would be a layering violation). <c>host</c> may also be an IP address.
        ///
        /// Please note that using <c>localhost</c> or <c>127.0.0.1</c> as a <c>host</c> is risky unless you take great care to run this webhook on all hosts which run an apiserver which might need to make calls to this webhook. Such installs are likely to be non-portable, i.e., not easy to turn up in a new cluster.
        ///
        /// The scheme must be "https"; the URL must begin with "https://".
        ///
        /// A path is optional, and if present may be any string permissible in a URL. You may use the path to pass an arbitrary string to the webhook, for example, a cluster identifier.
        ///
        /// Attempting to use a user or basic auth e.g. "user:password@" is not allowed. Fragments ("#...") and query parameters ("?...") are not allowed, either.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.WebhookClientConfig#url
        /// </remarks>
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Url
        {
            get
            {
                return null;
            }
        }

        /// <summary>WebhookClientConfig contains the information to make a TLS connection with the webhook.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.WebhookClientConfig
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IWebhookClientConfig), fullyQualifiedName: "k8s.WebhookClientConfig")]
        internal sealed class _Proxy : DeputyBase, K8s.IWebhookClientConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>`caBundle` is a PEM encoded CA bundle which will be used to validate the webhook's server certificate.</summary>
            /// <remarks>
            /// If unspecified, system trust roots on the apiserver are used.
            ///
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.WebhookClientConfig#caBundle
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "caBundle", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CaBundle
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>`service` is a reference to the service for this webhook. Either `service` or `url` must be specified.</summary>
            /// <remarks>
            /// If the webhook is running within the cluster, then you should use <c>service</c>.
            ///
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.WebhookClientConfig#service
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "service", typeJson: "{\"fqn\":\"k8s.ServiceReference\"}", isOptional: true)]
            public K8s.IServiceReference? Service
            {
                get => GetInstanceProperty<K8s.IServiceReference?>();
            }

            /// <summary>`url` gives the location of the webhook, in standard URL form (`scheme://host:port/path`).</summary>
            /// <remarks>
            /// Exactly one of <c>url</c> or <c>service</c> must be specified.
            ///
            /// The <c>host</c> should not refer to a service running in the cluster; use the <c>service</c> field instead. The host might be resolved via external DNS in some apiservers (e.g., <c>kube-apiserver</c> cannot resolve in-cluster DNS as that would be a layering violation). <c>host</c> may also be an IP address.
            ///
            /// Please note that using <c>localhost</c> or <c>127.0.0.1</c> as a <c>host</c> is risky unless you take great care to run this webhook on all hosts which run an apiserver which might need to make calls to this webhook. Such installs are likely to be non-portable, i.e., not easy to turn up in a new cluster.
            ///
            /// The scheme must be "https"; the URL must begin with "https://".
            ///
            /// A path is optional, and if present may be any string permissible in a URL. You may use the path to pass an arbitrary string to the webhook, for example, a cluster identifier.
            ///
            /// Attempting to use a user or basic auth e.g. "user:password@" is not allowed. Fragments ("#...") and query parameters ("?...") are not allowed, either.
            ///
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.WebhookClientConfig#url
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Url
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
