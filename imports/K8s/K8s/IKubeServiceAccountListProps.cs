using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ServiceAccountList is a list of ServiceAccount objects.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceAccountList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeServiceAccountListProps), fullyQualifiedName: "k8s.KubeServiceAccountListProps")]
    public interface IKubeServiceAccountListProps
    {
        /// <summary>List of ServiceAccounts.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/tasks/configure-pod-container/configure-service-account/
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceAccountList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeServiceAccountProps\"},\"kind\":\"array\"}}")]
        K8s.IKubeServiceAccountProps[] Items
        {
            get;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceAccountList#metadata
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

        /// <summary>ServiceAccountList is a list of ServiceAccount objects.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceAccountList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeServiceAccountListProps), fullyQualifiedName: "k8s.KubeServiceAccountListProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeServiceAccountListProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>List of ServiceAccounts.</summary>
            /// <remarks>
            /// More info: https://kubernetes.io/docs/tasks/configure-pod-container/configure-service-account/
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceAccountList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeServiceAccountProps\"},\"kind\":\"array\"}}")]
            public K8s.IKubeServiceAccountProps[] Items
            {
                get => GetInstanceProperty<K8s.IKubeServiceAccountProps[]>()!;
            }

            /// <summary>Standard list metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceAccountList#metadata
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
