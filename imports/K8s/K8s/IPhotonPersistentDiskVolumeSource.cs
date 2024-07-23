using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Represents a Photon Controller persistent disk resource.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.PhotonPersistentDiskVolumeSource
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IPhotonPersistentDiskVolumeSource), fullyQualifiedName: "k8s.PhotonPersistentDiskVolumeSource")]
    public interface IPhotonPersistentDiskVolumeSource
    {
        /// <summary>pdID is the ID that identifies Photon Controller persistent disk.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PhotonPersistentDiskVolumeSource#pdID
        /// </remarks>
        [JsiiProperty(name: "pdId", typeJson: "{\"primitive\":\"string\"}")]
        string PdId
        {
            get;
        }

        /// <summary>fsType is the filesystem type to mount.</summary>
        /// <remarks>
        /// Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PhotonPersistentDiskVolumeSource#fsType
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

        /// <summary>Represents a Photon Controller persistent disk resource.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PhotonPersistentDiskVolumeSource
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IPhotonPersistentDiskVolumeSource), fullyQualifiedName: "k8s.PhotonPersistentDiskVolumeSource")]
        internal sealed class _Proxy : DeputyBase, K8s.IPhotonPersistentDiskVolumeSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>pdID is the ID that identifies Photon Controller persistent disk.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PhotonPersistentDiskVolumeSource#pdID
            /// </remarks>
            [JsiiProperty(name: "pdId", typeJson: "{\"primitive\":\"string\"}")]
            public string PdId
            {
                get => GetInstanceProperty<string>()!;
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
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
