using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>PortworxVolumeSource represents a Portworx volume resource.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.PortworxVolumeSource
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IPortworxVolumeSource), fullyQualifiedName: "k8s.PortworxVolumeSource")]
    public interface IPortworxVolumeSource
    {
        /// <summary>volumeID uniquely identifies a Portworx volume.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PortworxVolumeSource#volumeID
        /// </remarks>
        [JsiiProperty(name: "volumeId", typeJson: "{\"primitive\":\"string\"}")]
        string VolumeId
        {
            get;
        }

        /// <summary>fSType represents the filesystem type to mount Must be a filesystem type supported by the host operating system.</summary>
        /// <remarks>
        /// Ex. "ext4", "xfs". Implicitly inferred to be "ext4" if unspecified.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PortworxVolumeSource#fsType
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

        /// <summary>readOnly defaults to false (read/write).</summary>
        /// <remarks>
        /// ReadOnly here will force the ReadOnly setting in VolumeMounts.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PortworxVolumeSource#readOnly
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

        /// <summary>PortworxVolumeSource represents a Portworx volume resource.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PortworxVolumeSource
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IPortworxVolumeSource), fullyQualifiedName: "k8s.PortworxVolumeSource")]
        internal sealed class _Proxy : DeputyBase, K8s.IPortworxVolumeSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>volumeID uniquely identifies a Portworx volume.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PortworxVolumeSource#volumeID
            /// </remarks>
            [JsiiProperty(name: "volumeId", typeJson: "{\"primitive\":\"string\"}")]
            public string VolumeId
            {
                get => GetInstanceProperty<string>()!;
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
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<bool?>();
            }
        }
    }
}
