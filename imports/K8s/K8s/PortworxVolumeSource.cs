using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>PortworxVolumeSource represents a Portworx volume resource.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.PortworxVolumeSource
    /// </remarks>
    [JsiiByValue(fqn: "k8s.PortworxVolumeSource")]
    public class PortworxVolumeSource : K8s.IPortworxVolumeSource
    {
        /// <summary>volumeID uniquely identifies a Portworx volume.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PortworxVolumeSource#volumeID
        /// </remarks>
        [JsiiProperty(name: "volumeId", typeJson: "{\"primitive\":\"string\"}")]
        public string VolumeId
        {
            get;
            set;
        }

        /// <summary>fSType represents the filesystem type to mount Must be a filesystem type supported by the host operating system.</summary>
        /// <remarks>
        /// Ex. "ext4", "xfs". Implicitly inferred to be "ext4" if unspecified.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PortworxVolumeSource#fsType
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fsType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FsType
        {
            get;
            set;
        }

        /// <summary>readOnly defaults to false (read/write).</summary>
        /// <remarks>
        /// ReadOnly here will force the ReadOnly setting in VolumeMounts.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PortworxVolumeSource#readOnly
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "readOnly", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? ReadOnly
        {
            get;
            set;
        }
    }
}
