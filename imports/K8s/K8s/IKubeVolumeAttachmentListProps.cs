using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>VolumeAttachmentList is a collection of VolumeAttachment objects.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.storage.v1.VolumeAttachmentList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeVolumeAttachmentListProps), fullyQualifiedName: "k8s.KubeVolumeAttachmentListProps")]
    public interface IKubeVolumeAttachmentListProps
    {
        /// <summary>items is the list of VolumeAttachments.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.VolumeAttachmentList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeVolumeAttachmentProps\"},\"kind\":\"array\"}}")]
        K8s.IKubeVolumeAttachmentProps[] Items
        {
            get;
        }

        /// <summary>Standard list metadata More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.VolumeAttachmentList#metadata
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

        /// <summary>VolumeAttachmentList is a collection of VolumeAttachment objects.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.VolumeAttachmentList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeVolumeAttachmentListProps), fullyQualifiedName: "k8s.KubeVolumeAttachmentListProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeVolumeAttachmentListProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>items is the list of VolumeAttachments.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.storage.v1.VolumeAttachmentList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeVolumeAttachmentProps\"},\"kind\":\"array\"}}")]
            public K8s.IKubeVolumeAttachmentProps[] Items
            {
                get => GetInstanceProperty<K8s.IKubeVolumeAttachmentProps[]>()!;
            }

            /// <summary>Standard list metadata More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.storage.v1.VolumeAttachmentList#metadata
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
