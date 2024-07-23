using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ResourceClaimList is a collection of claims.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaimList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeResourceClaimListV1Alpha2Props), fullyQualifiedName: "k8s.KubeResourceClaimListV1Alpha2Props")]
    public interface IKubeResourceClaimListV1Alpha2Props
    {
        /// <summary>Items is the list of resource claims.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaimList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeResourceClaimV1Alpha2Props\"},\"kind\":\"array\"}}")]
        K8s.IKubeResourceClaimV1Alpha2Props[] Items
        {
            get;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaimList#metadata
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

        /// <summary>ResourceClaimList is a collection of claims.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaimList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeResourceClaimListV1Alpha2Props), fullyQualifiedName: "k8s.KubeResourceClaimListV1Alpha2Props")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeResourceClaimListV1Alpha2Props
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Items is the list of resource claims.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaimList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeResourceClaimV1Alpha2Props\"},\"kind\":\"array\"}}")]
            public K8s.IKubeResourceClaimV1Alpha2Props[] Items
            {
                get => GetInstanceProperty<K8s.IKubeResourceClaimV1Alpha2Props[]>()!;
            }

            /// <summary>Standard list metadata.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaimList#metadata
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
