using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>AzureDisk represents an Azure Data Disk mount on the host and bind mount to the pod.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.AzureDiskVolumeSource
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IAzureDiskVolumeSource), fullyQualifiedName: "k8s.AzureDiskVolumeSource")]
    public interface IAzureDiskVolumeSource
    {
        /// <summary>diskName is the Name of the data disk in the blob storage.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.AzureDiskVolumeSource#diskName
        /// </remarks>
        [JsiiProperty(name: "diskName", typeJson: "{\"primitive\":\"string\"}")]
        string DiskName
        {
            get;
        }

        /// <summary>diskURI is the URI of data disk in the blob storage.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.AzureDiskVolumeSource#diskURI
        /// </remarks>
        [JsiiProperty(name: "diskUri", typeJson: "{\"primitive\":\"string\"}")]
        string DiskUri
        {
            get;
        }

        /// <summary>cachingMode is the Host Caching mode: None, Read Only, Read Write.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.AzureDiskVolumeSource#cachingMode
        /// </remarks>
        [JsiiProperty(name: "cachingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CachingMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>fsType is Filesystem type to mount.</summary>
        /// <remarks>
        /// Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.AzureDiskVolumeSource#fsType
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

        /// <summary>kind expected values are Shared: multiple blob disks per storage account  Dedicated: single blob disk per storage account  Managed: azure managed data disk (only in managed availability set).</summary>
        /// <remarks>
        /// defaults to shared
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.AzureDiskVolumeSource#kind
        /// </remarks>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Kind
        {
            get
            {
                return null;
            }
        }

        /// <summary>readOnly Defaults to false (read/write).</summary>
        /// <remarks>
        /// ReadOnly here will force the ReadOnly setting in VolumeMounts.
        ///
        /// <strong>Default</strong>: false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.AzureDiskVolumeSource#readOnly
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

        /// <summary>AzureDisk represents an Azure Data Disk mount on the host and bind mount to the pod.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.AzureDiskVolumeSource
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IAzureDiskVolumeSource), fullyQualifiedName: "k8s.AzureDiskVolumeSource")]
        internal sealed class _Proxy : DeputyBase, K8s.IAzureDiskVolumeSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>diskName is the Name of the data disk in the blob storage.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.AzureDiskVolumeSource#diskName
            /// </remarks>
            [JsiiProperty(name: "diskName", typeJson: "{\"primitive\":\"string\"}")]
            public string DiskName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>diskURI is the URI of data disk in the blob storage.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.AzureDiskVolumeSource#diskURI
            /// </remarks>
            [JsiiProperty(name: "diskUri", typeJson: "{\"primitive\":\"string\"}")]
            public string DiskUri
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>cachingMode is the Host Caching mode: None, Read Only, Read Write.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.AzureDiskVolumeSource#cachingMode
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cachingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CachingMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>fsType is Filesystem type to mount.</summary>
            /// <remarks>
            /// Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.AzureDiskVolumeSource#fsType
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fsType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FsType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>kind expected values are Shared: multiple blob disks per storage account  Dedicated: single blob disk per storage account  Managed: azure managed data disk (only in managed availability set).</summary>
            /// <remarks>
            /// defaults to shared
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.AzureDiskVolumeSource#kind
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Kind
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>readOnly Defaults to false (read/write).</summary>
            /// <remarks>
            /// ReadOnly here will force the ReadOnly setting in VolumeMounts.
            ///
            /// <strong>Default</strong>: false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.AzureDiskVolumeSource#readOnly
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
