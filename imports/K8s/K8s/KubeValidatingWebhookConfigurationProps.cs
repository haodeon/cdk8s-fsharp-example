using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ValidatingWebhookConfiguration describes the configuration of and admission webhook that accept or reject and object without changing it.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingWebhookConfiguration
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeValidatingWebhookConfigurationProps")]
    public class KubeValidatingWebhookConfigurationProps : K8s.IKubeValidatingWebhookConfigurationProps
    {
        /// <summary>Standard object metadata;</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingWebhookConfiguration#metadata
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        public K8s.IObjectMeta? Metadata
        {
            get;
            set;
        }

        /// <summary>Webhooks is a list of webhooks and the affected resources and operations.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingWebhookConfiguration#webhooks
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "webhooks", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.ValidatingWebhook\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.IValidatingWebhook[]? Webhooks
        {
            get;
            set;
        }
    }
}
