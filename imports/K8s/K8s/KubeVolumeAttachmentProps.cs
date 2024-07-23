using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>VolumeAttachment captures the intent to attach or detach the specified volume to/from the specified node.</summary>
    /// <remarks>
    /// VolumeAttachment objects are non-namespaced.
    ///
    /// <strong>Schema</strong>: io.k8s.api.storage.v1.VolumeAttachment
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeVolumeAttachmentProps")]
    public class KubeVolumeAttachmentProps : K8s.IKubeVolumeAttachmentProps
    {
        /// <summary>spec represents specification of the desired attach/detach volume behavior.</summary>
        /// <remarks>
        /// Populated by the Kubernetes system.
        ///
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.VolumeAttachment#spec
        /// </remarks>
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.VolumeAttachmentSpec\"}")]
        public K8s.IVolumeAttachmentSpec Spec
        {
            get;
            set;
        }

        /// <summary>Standard object metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.VolumeAttachment#metadata
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        public K8s.IObjectMeta? Metadata
        {
            get;
            set;
        }
    }
}
