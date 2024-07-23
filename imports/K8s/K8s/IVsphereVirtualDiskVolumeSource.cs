using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Represents a vSphere volume resource.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.VsphereVirtualDiskVolumeSource
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IVsphereVirtualDiskVolumeSource), fullyQualifiedName: "k8s.VsphereVirtualDiskVolumeSource")]
    public interface IVsphereVirtualDiskVolumeSource
    {
        /// <summary>volumePath is the path that identifies vSphere volume vmdk.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.VsphereVirtualDiskVolumeSource#volumePath
        /// </remarks>
        [JsiiProperty(name: "volumePath", typeJson: "{\"primitive\":\"string\"}")]
        string VolumePath
        {
            get;
        }

        /// <summary>fsType is filesystem type to mount.</summary>
        /// <remarks>
        /// Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.VsphereVirtualDiskVolumeSource#fsType
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

        /// <summary>storagePolicyID is the storage Policy Based Management (SPBM) profile ID associated with the StoragePolicyName.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.VsphereVirtualDiskVolumeSource#storagePolicyID
        /// </remarks>
        [JsiiProperty(name: "storagePolicyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StoragePolicyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>storagePolicyName is the storage Policy Based Management (SPBM) profile name.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.VsphereVirtualDiskVolumeSource#storagePolicyName
        /// </remarks>
        [JsiiProperty(name: "storagePolicyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StoragePolicyName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Represents a vSphere volume resource.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.VsphereVirtualDiskVolumeSource
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IVsphereVirtualDiskVolumeSource), fullyQualifiedName: "k8s.VsphereVirtualDiskVolumeSource")]
        internal sealed class _Proxy : DeputyBase, K8s.IVsphereVirtualDiskVolumeSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>volumePath is the path that identifies vSphere volume vmdk.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.VsphereVirtualDiskVolumeSource#volumePath
            /// </remarks>
            [JsiiProperty(name: "volumePath", typeJson: "{\"primitive\":\"string\"}")]
            public string VolumePath
            {
                get => GetInstanceProperty<string>()!;
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
                get => GetInstanceProperty<string?>();
            }

            /// <summary>storagePolicyID is the storage Policy Based Management (SPBM) profile ID associated with the StoragePolicyName.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.VsphereVirtualDiskVolumeSource#storagePolicyID
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storagePolicyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StoragePolicyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>storagePolicyName is the storage Policy Based Management (SPBM) profile name.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.VsphereVirtualDiskVolumeSource#storagePolicyName
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storagePolicyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StoragePolicyName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
