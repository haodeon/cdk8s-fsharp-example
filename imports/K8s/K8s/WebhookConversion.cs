using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>WebhookConversion describes how to call a conversion webhook.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.WebhookConversion
    /// </remarks>
    [JsiiByValue(fqn: "k8s.WebhookConversion")]
    public class WebhookConversion : K8s.IWebhookConversion
    {
        /// <summary>conversionReviewVersions is an ordered list of preferred `ConversionReview` versions the Webhook expects.</summary>
        /// <remarks>
        /// The API server will use the first version in the list which it supports. If none of the versions specified in this list are supported by API server, conversion will fail for the custom resource. If a persisted Webhook configuration specifies allowed versions and does not include any versions known to the API Server, calls to the webhook will fail.
        ///
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.WebhookConversion#conversionReviewVersions
        /// </remarks>
        [JsiiProperty(name: "conversionReviewVersions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] ConversionReviewVersions
        {
            get;
            set;
        }

        /// <summary>clientConfig is the instructions for how to call the webhook if strategy is `Webhook`.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.WebhookConversion#clientConfig
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clientConfig", typeJson: "{\"fqn\":\"k8s.WebhookClientConfig\"}", isOptional: true)]
        public K8s.IWebhookClientConfig? ClientConfig
        {
            get;
            set;
        }
    }
}
