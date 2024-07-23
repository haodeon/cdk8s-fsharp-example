using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>MutatingWebhookConfiguration describes the configuration of and admission webhook that accept or reject and may change the object.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.MutatingWebhookConfiguration
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeMutatingWebhookConfigurationProps")]
    public class KubeMutatingWebhookConfigurationProps : K8s.IKubeMutatingWebhookConfigurationProps
    {
        /// <summary>Standard object metadata;</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.MutatingWebhookConfiguration#metadata
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
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.MutatingWebhookConfiguration#webhooks
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "webhooks", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.MutatingWebhook\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.IMutatingWebhook[]? Webhooks
        {
            get;
            set;
        }
    }
}
