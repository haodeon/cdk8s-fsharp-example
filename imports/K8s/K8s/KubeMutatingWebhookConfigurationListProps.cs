using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>MutatingWebhookConfigurationList is a list of MutatingWebhookConfiguration.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.MutatingWebhookConfigurationList
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeMutatingWebhookConfigurationListProps")]
    public class KubeMutatingWebhookConfigurationListProps : K8s.IKubeMutatingWebhookConfigurationListProps
    {
        /// <summary>List of MutatingWebhookConfiguration.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.MutatingWebhookConfigurationList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeMutatingWebhookConfigurationProps\"},\"kind\":\"array\"}}")]
        public K8s.IKubeMutatingWebhookConfigurationProps[] Items
        {
            get;
            set;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.MutatingWebhookConfigurationList#metadata
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ListMeta\"}", isOptional: true)]
        public K8s.IListMeta? Metadata
        {
            get;
            set;
        }
    }
}