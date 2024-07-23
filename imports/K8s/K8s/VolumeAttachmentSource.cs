using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>VolumeAttachmentSource represents a volume that should be attached.</summary>
    /// <remarks>
    /// Right now only PersistenVolumes can be attached via external attacher, in future we may allow also inline volumes in pods. Exactly one member can be set.
    ///
    /// <strong>Schema</strong>: io.k8s.api.storage.v1.VolumeAttachmentSource
    /// </remarks>
    [JsiiByValue(fqn: "k8s.VolumeAttachmentSource")]
    public class VolumeAttachmentSource : K8s.IVolumeAttachmentSource
    {
        /// <summary>inlineVolumeSpec contains all the information necessary to attach a persistent volume defined by a pod's inline VolumeSource.</summary>
        /// <remarks>
        /// This field is populated only for the CSIMigration feature. It contains translated fields from a pod's inline VolumeSource to a PersistentVolumeSpec. This field is beta-level and is only honored by servers that enabled the CSIMigration feature.
        ///
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.VolumeAttachmentSource#inlineVolumeSpec
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "inlineVolumeSpec", typeJson: "{\"fqn\":\"k8s.PersistentVolumeSpec\"}", isOptional: true)]
        public K8s.IPersistentVolumeSpec? InlineVolumeSpec
        {
            get;
            set;
        }

        /// <summary>persistentVolumeName represents the name of the persistent volume to attach.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.VolumeAttachmentSource#persistentVolumeName
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "persistentVolumeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PersistentVolumeName
        {
            get;
            set;
        }
    }
}
