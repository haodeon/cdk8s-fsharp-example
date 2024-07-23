using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Represents a Persistent Disk resource in Google Compute Engine.</summary>
    /// <remarks>
    /// A GCE PD must exist before mounting to a container. The disk must also be in the same GCE project and zone as the kubelet. A GCE PD can only be mounted as read/write once or read-only many times. GCE PDs support ownership management and SELinux relabeling.
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.GCEPersistentDiskVolumeSource
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IGcePersistentDiskVolumeSource), fullyQualifiedName: "k8s.GcePersistentDiskVolumeSource")]
    public interface IGcePersistentDiskVolumeSource
    {
        /// <summary>pdName is unique name of the PD resource in GCE.</summary>
        /// <remarks>
        /// Used to identify the disk in GCE. More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.GCEPersistentDiskVolumeSource#pdName
        /// </remarks>
        [JsiiProperty(name: "pdName", typeJson: "{\"primitive\":\"string\"}")]
        string PdName
        {
            get;
        }

        /// <summary>fsType is filesystem type of the volume that you want to mount.</summary>
        /// <remarks>
        /// Tip: Ensure that the filesystem type is supported by the host operating system. Examples: "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified. More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.GCEPersistentDiskVolumeSource#fsType
        /// </remarks>
        [JsiiProperty(name: "fsType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FsType
        {
            get
            {
                return null;
            }
        }

        /// <summary>partition is the partition in the volume that you want to mount.</summary>
        /// <remarks>
        /// If omitted, the default is to mount by volume name. Examples: For volume /dev/sda1, you specify the partition as "1". Similarly, the volume partition for /dev/sda is "0" (or you can leave the property empty). More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.GCEPersistentDiskVolumeSource#partition
        /// </remarks>
        [JsiiProperty(name: "partition", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Partition
        {
            get
            {
                return null;
            }
        }

        /// <summary>readOnly here will force the ReadOnly setting in VolumeMounts.</summary>
        /// <remarks>
        /// Defaults to false. More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk
        ///
        /// <strong>Default</strong>: false. More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.GCEPersistentDiskVolumeSource#readOnly
        /// </remarks>
        [JsiiProperty(name: "readOnly", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? ReadOnly
        {
            get
            {
                return null;
            }
        }

        /// <summary>Represents a Persistent Disk resource in Google Compute Engine.</summary>
        /// <remarks>
        /// A GCE PD must exist before mounting to a container. The disk must also be in the same GCE project and zone as the kubelet. A GCE PD can only be mounted as read/write once or read-only many times. GCE PDs support ownership management and SELinux relabeling.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.GCEPersistentDiskVolumeSource
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IGcePersistentDiskVolumeSource), fullyQualifiedName: "k8s.GcePersistentDiskVolumeSource")]
        internal sealed class _Proxy : DeputyBase, K8s.IGcePersistentDiskVolumeSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>pdName is unique name of the PD resource in GCE.</summary>
            /// <remarks>
            /// Used to identify the disk in GCE. More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.GCEPersistentDiskVolumeSource#pdName
            /// </remarks>
            [JsiiProperty(name: "pdName", typeJson: "{\"primitive\":\"string\"}")]
            public string PdName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>fsType is filesystem type of the volume that you want to mount.</summary>
            /// <remarks>
            /// Tip: Ensure that the filesystem type is supported by the host operating system. Examples: "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified. More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.GCEPersistentDiskVolumeSource#fsType
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fsType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FsType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>partition is the partition in the volume that you want to mount.</summary>
            /// <remarks>
            /// If omitted, the default is to mount by volume name. Examples: For volume /dev/sda1, you specify the partition as "1". Similarly, the volume partition for /dev/sda is "0" (or you can leave the property empty). More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.GCEPersistentDiskVolumeSource#partition
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "partition", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Partition
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>readOnly here will force the ReadOnly setting in VolumeMounts.</summary>
            /// <remarks>
            /// Defaults to false. More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk
            ///
            /// <strong>Default</strong>: false. More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.GCEPersistentDiskVolumeSource#readOnly
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "readOnly", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? ReadOnly
            {
                get => GetInstanceProperty<bool?>();
            }
        }
    }
}