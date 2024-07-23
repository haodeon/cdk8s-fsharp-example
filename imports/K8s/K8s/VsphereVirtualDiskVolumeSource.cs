using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>Represents a vSphere volume resource.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.VsphereVirtualDiskVolumeSource
    /// </remarks>
    [JsiiByValue(fqn: "k8s.VsphereVirtualDiskVolumeSource")]
    public class VsphereVirtualDiskVolumeSource : K8s.IVsphereVirtualDiskVolumeSource
    {
        /// <summary>volumePath is the path that identifies vSphere volume vmdk.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.VsphereVirtualDiskVolumeSource#volumePath
        /// </remarks>
        [JsiiProperty(name: "volumePath", typeJson: "{\"primitive\":\"string\"}")]
        public string VolumePath
        {
            get;
            set;
        }

        /// <summary>fsType is filesystem type to mount.</summary>
        /// <remarks>
        /// Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.VsphereVirtualDiskVolumeSource#fsType
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fsType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FsType
        {
            get;
            set;
        }

        /// <summary>storagePolicyID is the storage Policy Based Management (SPBM) profile ID associated with the StoragePolicyName.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.VsphereVirtualDiskVolumeSource#storagePolicyID
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "storagePolicyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StoragePolicyId
        {
            get;
            set;
        }

        /// <summary>storagePolicyName is the storage Policy Based Management (SPBM) profile name.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.VsphereVirtualDiskVolumeSource#storagePolicyName
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "storagePolicyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StoragePolicyName
        {
            get;
            set;
        }
    }
}
