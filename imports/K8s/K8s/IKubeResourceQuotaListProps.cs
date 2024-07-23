using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ResourceQuotaList is a list of ResourceQuota items.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ResourceQuotaList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeResourceQuotaListProps), fullyQualifiedName: "k8s.KubeResourceQuotaListProps")]
    public interface IKubeResourceQuotaListProps
    {
        /// <summary>Items is a list of ResourceQuota objects.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/policy/resource-quotas/
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ResourceQuotaList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeResourceQuotaProps\"},\"kind\":\"array\"}}")]
        K8s.IKubeResourceQuotaProps[] Items
        {
            get;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ResourceQuotaList#metadata
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

        /// <summary>ResourceQuotaList is a list of ResourceQuota items.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ResourceQuotaList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeResourceQuotaListProps), fullyQualifiedName: "k8s.KubeResourceQuotaListProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeResourceQuotaListProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Items is a list of ResourceQuota objects.</summary>
            /// <remarks>
            /// More info: https://kubernetes.io/docs/concepts/policy/resource-quotas/
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ResourceQuotaList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeResourceQuotaProps\"},\"kind\":\"array\"}}")]
            public K8s.IKubeResourceQuotaProps[] Items
            {
                get => GetInstanceProperty<K8s.IKubeResourceQuotaProps[]>()!;
            }

            /// <summary>Standard list metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ResourceQuotaList#metadata
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
