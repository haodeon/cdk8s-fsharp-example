using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ValidatingWebhookConfiguration describes the configuration of and admission webhook that accept or reject and object without changing it.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingWebhookConfiguration
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeValidatingWebhookConfigurationProps), fullyQualifiedName: "k8s.KubeValidatingWebhookConfigurationProps")]
    public interface IKubeValidatingWebhookConfigurationProps
    {
        /// <summary>Standard object metadata;</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingWebhookConfiguration#metadata
        /// </remarks>
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IObjectMeta? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>Webhooks is a list of webhooks and the affected resources and operations.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingWebhookConfiguration#webhooks
        /// </remarks>
        [JsiiProperty(name: "webhooks", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.ValidatingWebhook\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IValidatingWebhook[]? Webhooks
        {
            get
            {
                return null;
            }
        }

        /// <summary>ValidatingWebhookConfiguration describes the configuration of and admission webhook that accept or reject and object without changing it.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingWebhookConfiguration
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeValidatingWebhookConfigurationProps), fullyQualifiedName: "k8s.KubeValidatingWebhookConfigurationProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeValidatingWebhookConfigurationProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

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
                get => GetInstanceProperty<K8s.IObjectMeta?>();
            }

            /// <summary>Webhooks is a list of webhooks and the affected resources and operations.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingWebhookConfiguration#webhooks
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "webhooks", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.ValidatingWebhook\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.IValidatingWebhook[]? Webhooks
            {
                get => GetInstanceProperty<K8s.IValidatingWebhook[]?>();
            }
        }
    }
}
