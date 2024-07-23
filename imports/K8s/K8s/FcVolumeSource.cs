using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Represents a Fibre Channel volume.</summary>
    /// <remarks>
    /// Fibre Channel volumes can only be mounted as read/write once. Fibre Channel volumes support ownership management and SELinux relabeling.
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.FCVolumeSource
    /// </remarks>
    [JsiiByValue(fqn: "k8s.FcVolumeSource")]
    public class FcVolumeSource : K8s.IFcVolumeSource
    {
        /// <summary>fsType is the filesystem type to mount.</summary>
        /// <remarks>
        /// Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.FCVolumeSource#fsType
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fsType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FsType
        {
            get;
            set;
        }

        /// <summary>lun is Optional: FC target lun number.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.FCVolumeSource#lun
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lun", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Lun
        {
            get;
            set;
        }

        /// <summary>readOnly is Optional: Defaults to false (read/write).</summary>
        /// <remarks>
        /// ReadOnly here will force the ReadOnly setting in VolumeMounts.
        ///
        /// <strong>Default</strong>: false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.FCVolumeSource#readOnly
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "readOnly", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? ReadOnly
        {
            get;
            set;
        }

        /// <summary>targetWWNs is Optional: FC target worldwide names (WWNs).</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.FCVolumeSource#targetWWNs
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "targetWwNs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? TargetWwNs
        {
            get;
            set;
        }

        /// <summary>wwids Optional: FC volume world wide identifiers (wwids) Either wwids or combination of targetWWNs and lun must be set, but not both simultaneously.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.FCVolumeSource#wwids
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "wwids", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Wwids
        {
            get;
            set;
        }
    }
}
