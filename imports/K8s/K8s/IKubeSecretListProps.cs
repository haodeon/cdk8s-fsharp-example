using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>SecretList is a list of Secret.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.SecretList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeSecretListProps), fullyQualifiedName: "k8s.KubeSecretListProps")]
    public interface IKubeSecretListProps
    {
        /// <summary>Items is a list of secret objects.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/configuration/secret
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SecretList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeSecretProps\"},\"kind\":\"array\"}}")]
        K8s.IKubeSecretProps[] Items
        {
            get;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SecretList#metadata
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

        /// <summary>SecretList is a list of Secret.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SecretList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeSecretListProps), fullyQualifiedName: "k8s.KubeSecretListProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeSecretListProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Items is a list of secret objects.</summary>
            /// <remarks>
            /// More info: https://kubernetes.io/docs/concepts/configuration/secret
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.SecretList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeSecretProps\"},\"kind\":\"array\"}}")]
            public K8s.IKubeSecretProps[] Items
            {
                get => GetInstanceProperty<K8s.IKubeSecretProps[]>()!;
            }

            /// <summary>Standard list metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.SecretList#metadata
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
