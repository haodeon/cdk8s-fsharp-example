using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ResourceClaimTemplateList is a collection of claim templates.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaimTemplateList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeResourceClaimTemplateListV1Alpha2Props), fullyQualifiedName: "k8s.KubeResourceClaimTemplateListV1Alpha2Props")]
    public interface IKubeResourceClaimTemplateListV1Alpha2Props
    {
        /// <summary>Items is the list of resource claim templates.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaimTemplateList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeResourceClaimTemplateV1Alpha2Props\"},\"kind\":\"array\"}}")]
        K8s.IKubeResourceClaimTemplateV1Alpha2Props[] Items
        {
            get;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaimTemplateList#metadata
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

        /// <summary>ResourceClaimTemplateList is a collection of claim templates.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaimTemplateList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeResourceClaimTemplateListV1Alpha2Props), fullyQualifiedName: "k8s.KubeResourceClaimTemplateListV1Alpha2Props")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeResourceClaimTemplateListV1Alpha2Props
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Items is the list of resource claim templates.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaimTemplateList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeResourceClaimTemplateV1Alpha2Props\"},\"kind\":\"array\"}}")]
            public K8s.IKubeResourceClaimTemplateV1Alpha2Props[] Items
            {
                get => GetInstanceProperty<K8s.IKubeResourceClaimTemplateV1Alpha2Props[]>()!;
            }

            /// <summary>Standard list metadata.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaimTemplateList#metadata
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
