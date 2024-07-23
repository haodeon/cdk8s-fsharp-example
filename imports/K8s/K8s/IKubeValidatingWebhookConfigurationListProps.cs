using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ValidatingWebhookConfigurationList is a list of ValidatingWebhookConfiguration.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingWebhookConfigurationList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeValidatingWebhookConfigurationListProps), fullyQualifiedName: "k8s.KubeValidatingWebhookConfigurationListProps")]
    public interface IKubeValidatingWebhookConfigurationListProps
    {
        /// <summary>List of ValidatingWebhookConfiguration.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingWebhookConfigurationList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeValidatingWebhookConfigurationProps\"},\"kind\":\"array\"}}")]
        K8s.IKubeValidatingWebhookConfigurationProps[] Items
        {
            get;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingWebhookConfigurationList#metadata
        /// </remarks>
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ListMeta\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IListMeta? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>ValidatingWebhookConfigurationList is a list of ValidatingWebhookConfiguration.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingWebhookConfigurationList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeValidatingWebhookConfigurationListProps), fullyQualifiedName: "k8s.KubeValidatingWebhookConfigurationListProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeValidatingWebhookConfigurationListProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>List of ValidatingWebhookConfiguration.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingWebhookConfigurationList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeValidatingWebhookConfigurationProps\"},\"kind\":\"array\"}}")]
            public K8s.IKubeValidatingWebhookConfigurationProps[] Items
            {
                get => GetInstanceProperty<K8s.IKubeValidatingWebhookConfigurationProps[]>()!;
            }

            /// <summary>Standard list metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
            ///
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingWebhookConfigurationList#metadata
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ListMeta\"}", isOptional: true)]
            public K8s.IListMeta? Metadata
            {
                get => GetInstanceProperty<K8s.IListMeta?>();
            }
        }
    }
}
