using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>Local represents directly-attached storage with node affinity (Beta feature).</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.LocalVolumeSource
    /// </remarks>
    [JsiiByValue(fqn: "k8s.LocalVolumeSource")]
    public class LocalVolumeSource : K8s.ILocalVolumeSource
    {
        /// <summary>path of the full path to the volume on the node.</summary>
        /// <remarks>
        /// It can be either a directory or block device (disk, partition, ...).
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.LocalVolumeSource#path
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public string Path
        {
            get;
            set;
        }

        /// <summary>fsType is the filesystem type to mount.</summary>
        /// <remarks>
        /// It applies only when the Path is a block device. Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". The default value is to auto-select a filesystem if unspecified.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.LocalVolumeSource#fsType
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
