using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>WebhookConversion describes how to call a conversion webhook.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.WebhookConversion
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IWebhookConversion), fullyQualifiedName: "k8s.WebhookConversion")]
    public interface IWebhookConversion
    {
        /// <summary>conversionReviewVersions is an ordered list of preferred `ConversionReview` versions the Webhook expects.</summary>
        /// <remarks>
        /// The API server will use the first version in the list which it supports. If none of the versions specified in this list are supported by API server, conversion will fail for the custom resource. If a persisted Webhook configuration specifies allowed versions and does not include any versions known to the API Server, calls to the webhook will fail.
        ///
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.WebhookConversion#conversionReviewVersions
        /// </remarks>
        [JsiiProperty(name: "conversionReviewVersions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] ConversionReviewVersions
        {
            get;
        }

        /// <summary>clientConfig is the instructions for how to call the webhook if strategy is `Webhook`.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.WebhookConversion#clientConfig
        /// </remarks>
        [JsiiProperty(name: "clientConfig", typeJson: "{\"fqn\":\"k8s.WebhookClientConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IWebhookClientConfig? ClientConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>WebhookConversion describes how to call a conversion webhook.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.WebhookConversion
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IWebhookConversion), fullyQualifiedName: "k8s.WebhookConversion")]
        internal sealed class _Proxy : DeputyBase, K8s.IWebhookConversion
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>conversionReviewVersions is an ordered list of preferred `ConversionReview` versions the Webhook expects.</summary>
            /// <remarks>
            /// The API server will use the first version in the list which it supports. If none of the versions specified in this list are supported by API server, conversion will fail for the custom resource. If a persisted Webhook configuration specifies allowed versions and does not include any versions known to the API Server, calls to the webhook will fail.
            ///
            /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.WebhookConversion#conversionReviewVersions
            /// </remarks>
            [JsiiProperty(name: "conversionReviewVersions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] ConversionReviewVersions
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>clientConfig is the instructions for how to call the webhook if strategy is `Webhook`.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.WebhookConversion#clientConfig
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientConfig", typeJson: "{\"fqn\":\"k8s.WebhookClientConfig\"}", isOptional: true)]
            public K8s.IWebhookClientConfig? ClientConfig
            {
                get => GetInstanceProperty<K8s.IWebhookClientConfig?>();
            }
        }
    }
}
