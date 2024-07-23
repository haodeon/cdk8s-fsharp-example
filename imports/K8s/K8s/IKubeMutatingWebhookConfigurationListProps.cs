using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>MutatingWebhookConfigurationList is a list of MutatingWebhookConfiguration.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.MutatingWebhookConfigurationList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeMutatingWebhookConfigurationListProps), fullyQualifiedName: "k8s.KubeMutatingWebhookConfigurationListProps")]
    public interface IKubeMutatingWebhookConfigurationListProps
    {
        /// <summary>List of MutatingWebhookConfiguration.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.MutatingWebhookConfigurationList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeMutatingWebhookConfigurationProps\"},\"kind\":\"array\"}}")]
        K8s.IKubeMutatingWebhookConfigurationProps[] Items
        {
            get;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.MutatingWebhookConfigurationList#metadata
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

        /// <summary>MutatingWebhookConfigurationList is a list of MutatingWebhookConfiguration.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.MutatingWebhookConfigurationList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeMutatingWebhookConfigurationListProps), fullyQualifiedName: "k8s.KubeMutatingWebhookConfigurationListProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeMutatingWebhookConfigurationListProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>List of MutatingWebhookConfiguration.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.MutatingWebhookConfigurationList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeMutatingWebhookConfigurationProps\"},\"kind\":\"array\"}}")]
            public K8s.IKubeMutatingWebhookConfigurationProps[] Items
            {
                get => GetInstanceProperty<K8s.IKubeMutatingWebhookConfigurationProps[]>()!;
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
                get => GetInstanceProperty<K8s.IListMeta?>();
            }
        }
    }
}
