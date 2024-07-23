using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>VolumeAttachmentSpec is the specification of a VolumeAttachment request.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.storage.v1.VolumeAttachmentSpec
    /// </remarks>
    [JsiiByValue(fqn: "k8s.VolumeAttachmentSpec")]
    public class VolumeAttachmentSpec : K8s.IVolumeAttachmentSpec
    {
        /// <summary>attacher indicates the name of the volume driver that MUST handle this request.</summary>
        /// <remarks>
        /// This is the name returned by GetPluginName().
        ///
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.VolumeAttachmentSpec#attacher
        /// </remarks>
        [JsiiProperty(name: "attacher", typeJson: "{\"primitive\":\"string\"}")]
        public string Attacher
        {
            get;
            set;
        }

        /// <summary>nodeName represents the node that the volume should be attached to.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.VolumeAttachmentSpec#nodeName
        /// </remarks>
        [JsiiProperty(name: "nodeName", typeJson: "{\"primitive\":\"string\"}")]
        public string NodeName
        {
            get;
            set;
        }

        /// <summary>source represents the volume that should be attached.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.VolumeAttachmentSpec#source
        /// </remarks>
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"k8s.VolumeAttachmentSource\"}")]
        public K8s.IVolumeAttachmentSource Source
        {
            get;
            set;
        }
    }
}
