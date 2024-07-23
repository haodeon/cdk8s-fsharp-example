using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Represents a StorageOS persistent volume resource.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.StorageOSPersistentVolumeSource
    /// </remarks>
    [JsiiByValue(fqn: "k8s.StorageOsPersistentVolumeSource")]
    public class StorageOsPersistentVolumeSource : K8s.IStorageOsPersistentVolumeSource
    {
        /// <summary>fsType is the filesystem type to mount.</summary>
        /// <remarks>
        /// Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.StorageOSPersistentVolumeSource#fsType
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
        /// <strong>Schema</strong>: io.k8s.api.core.v1.StorageOSPersistentVolumeSource#readOnly
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "readOnly", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? ReadOnly
        {
            get;
            set;
        }

        /// <summary>secretRef specifies the secret to use for obtaining the StorageOS API credentials.</summary>
        /// <remarks>
        /// If not specified, default values will be attempted.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.StorageOSPersistentVolumeSource#secretRef
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secretRef", typeJson: "{\"fqn\":\"k8s.ObjectReference\"}", isOptional: true)]
        public K8s.IObjectReference? SecretRef
        {
            get;
            set;
        }

        /// <summary>volumeName is the human-readable name of the StorageOS volume.</summary>
        /// <remarks>
        /// Volume names are only unique within a namespace.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.StorageOSPersistentVolumeSource#volumeName
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "volumeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VolumeName
        {
            get;
            set;
        }

        /// <summary>volumeNamespace specifies the scope of the volume within StorageOS.</summary>
        /// <remarks>
        /// If no namespace is specified then the Pod's namespace will be used.  This allows the Kubernetes name scoping to be mirrored within StorageOS for tighter integration. Set VolumeName to any name to override the default behaviour. Set to "default" if you are not using namespaces within StorageOS. Namespaces that do not pre-exist within StorageOS will be created.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.StorageOSPersistentVolumeSource#volumeNamespace
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "volumeNamespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VolumeNamespace
        {
            get;
            set;
        }
    }
}
