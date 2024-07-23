using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ResourceClassList is a collection of classes.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClassList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeResourceClassListV1Alpha2Props), fullyQualifiedName: "k8s.KubeResourceClassListV1Alpha2Props")]
    public interface IKubeResourceClassListV1Alpha2Props
    {
        /// <summary>Items is the list of resource classes.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClassList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeResourceClassV1Alpha2Props\"},\"kind\":\"array\"}}")]
        K8s.IKubeResourceClassV1Alpha2Props[] Items
        {
            get;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClassList#metadata
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

        /// <summary>ResourceClassList is a collection of classes.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClassList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeResourceClassListV1Alpha2Props), fullyQualifiedName: "k8s.KubeResourceClassListV1Alpha2Props")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeResourceClassListV1Alpha2Props
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Items is the list of resource classes.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClassList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeResourceClassV1Alpha2Props\"},\"kind\":\"array\"}}")]
            public K8s.IKubeResourceClassV1Alpha2Props[] Items
            {
                get => GetInstanceProperty<K8s.IKubeResourceClassV1Alpha2Props[]>()!;
            }

            /// <summary>Standard list metadata.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClassList#metadata
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
