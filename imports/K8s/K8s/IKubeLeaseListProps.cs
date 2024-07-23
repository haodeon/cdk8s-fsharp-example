using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>LeaseList is a list of Lease objects.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.coordination.v1.LeaseList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeLeaseListProps), fullyQualifiedName: "k8s.KubeLeaseListProps")]
    public interface IKubeLeaseListProps
    {
        /// <summary>items is a list of schema objects.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.coordination.v1.LeaseList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeLeaseProps\"},\"kind\":\"array\"}}")]
        K8s.IKubeLeaseProps[] Items
        {
            get;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.coordination.v1.LeaseList#metadata
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

        /// <summary>LeaseList is a list of Lease objects.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.coordination.v1.LeaseList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeLeaseListProps), fullyQualifiedName: "k8s.KubeLeaseListProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeLeaseListProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>items is a list of schema objects.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.coordination.v1.LeaseList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeLeaseProps\"},\"kind\":\"array\"}}")]
            public K8s.IKubeLeaseProps[] Items
            {
                get => GetInstanceProperty<K8s.IKubeLeaseProps[]>()!;
            }

            /// <summary>Standard list metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
            ///
            /// <strong>Schema</strong>: io.k8s.api.coordination.v1.LeaseList#metadata
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
