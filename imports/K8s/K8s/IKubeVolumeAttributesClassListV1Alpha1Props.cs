using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>VolumeAttributesClassList is a collection of VolumeAttributesClass objects.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.storage.v1alpha1.VolumeAttributesClassList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeVolumeAttributesClassListV1Alpha1Props), fullyQualifiedName: "k8s.KubeVolumeAttributesClassListV1Alpha1Props")]
    public interface IKubeVolumeAttributesClassListV1Alpha1Props
    {
        /// <summary>items is the list of VolumeAttributesClass objects.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storage.v1alpha1.VolumeAttributesClassList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeVolumeAttributesClassV1Alpha1Props\"},\"kind\":\"array\"}}")]
        K8s.IKubeVolumeAttributesClassV1Alpha1Props[] Items
        {
            get;
        }

        /// <summary>Standard list metadata More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storage.v1alpha1.VolumeAttributesClassList#metadata
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

        /// <summary>VolumeAttributesClassList is a collection of VolumeAttributesClass objects.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storage.v1alpha1.VolumeAttributesClassList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeVolumeAttributesClassListV1Alpha1Props), fullyQualifiedName: "k8s.KubeVolumeAttributesClassListV1Alpha1Props")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeVolumeAttributesClassListV1Alpha1Props
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>items is the list of VolumeAttributesClass objects.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.storage.v1alpha1.VolumeAttributesClassList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeVolumeAttributesClassV1Alpha1Props\"},\"kind\":\"array\"}}")]
            public K8s.IKubeVolumeAttributesClassV1Alpha1Props[] Items
            {
                get => GetInstanceProperty<K8s.IKubeVolumeAttributesClassV1Alpha1Props[]>()!;
            }

            /// <summary>Standard list metadata More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.storage.v1alpha1.VolumeAttributesClassList#metadata
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
