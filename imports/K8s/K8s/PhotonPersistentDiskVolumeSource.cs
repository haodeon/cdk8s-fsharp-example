using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>Represents a Photon Controller persistent disk resource.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.PhotonPersistentDiskVolumeSource
    /// </remarks>
    [JsiiByValue(fqn: "k8s.PhotonPersistentDiskVolumeSource")]
    public class PhotonPersistentDiskVolumeSource : K8s.IPhotonPersistentDiskVolumeSource
    {
        /// <summary>pdID is the ID that identifies Photon Controller persistent disk.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PhotonPersistentDiskVolumeSource#pdID
        /// </remarks>
        [JsiiProperty(name: "pdId", typeJson: "{\"primitive\":\"string\"}")]
        public string PdId
        {
            get;
            set;
        }

        /// <summary>fsType is the filesystem type to mount.</summary>
        /// <remarks>
        /// Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PhotonPersistentDiskVolumeSource#fsType
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fsType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FsType
        {
            get;
            set;
        }
    }
}
