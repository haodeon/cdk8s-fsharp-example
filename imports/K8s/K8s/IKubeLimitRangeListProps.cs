using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>LimitRangeList is a list of LimitRange items.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.LimitRangeList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeLimitRangeListProps), fullyQualifiedName: "k8s.KubeLimitRangeListProps")]
    public interface IKubeLimitRangeListProps
    {
        /// <summary>Items is a list of LimitRange objects.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.LimitRangeList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeLimitRangeProps\"},\"kind\":\"array\"}}")]
        K8s.IKubeLimitRangeProps[] Items
        {
            get;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.LimitRangeList#metadata
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

        /// <summary>LimitRangeList is a list of LimitRange items.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.LimitRangeList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeLimitRangeListProps), fullyQualifiedName: "k8s.KubeLimitRangeListProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeLimitRangeListProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Items is a list of LimitRange objects.</summary>
            /// <remarks>
            /// More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.LimitRangeList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeLimitRangeProps\"},\"kind\":\"array\"}}")]
            public K8s.IKubeLimitRangeProps[] Items
            {
                get => GetInstanceProperty<K8s.IKubeLimitRangeProps[]>()!;
            }

            /// <summary>Standard list metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.LimitRangeList#metadata
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
