using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>VolumeAttachmentList is a collection of VolumeAttachment objects.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.storage.v1.VolumeAttachmentList
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeVolumeAttachmentListProps")]
    public class KubeVolumeAttachmentListProps : K8s.IKubeVolumeAttachmentListProps
    {
        /// <summary>items is the list of VolumeAttachments.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.VolumeAttachmentList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeVolumeAttachmentProps\"},\"kind\":\"array\"}}")]
        public K8s.IKubeVolumeAttachmentProps[] Items
        {
            get;
            set;
        }

        /// <summary>Standard list metadata More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.VolumeAttachmentList#metadata
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ListMeta\"}", isOptional: true)]
        public K8s.IListMeta? Metadata
        {
            get;
            set;
        }
    }
}
