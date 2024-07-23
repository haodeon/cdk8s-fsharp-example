using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ScaleIOVolumeSource represents a persistent ScaleIO volume.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ScaleIOVolumeSource
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IScaleIoVolumeSource), fullyQualifiedName: "k8s.ScaleIoVolumeSource")]
    public interface IScaleIoVolumeSource
    {
        /// <summary>gateway is the host address of the ScaleIO API Gateway.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ScaleIOVolumeSource#gateway
        /// </remarks>
        [JsiiProperty(name: "gateway", typeJson: "{\"primitive\":\"string\"}")]
        string Gateway
        {
            get;
        }

        /// <summary>secretRef references to the secret for ScaleIO user and other sensitive information.</summary>
        /// <remarks>
        /// If this is not provided, Login operation will fail.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ScaleIOVolumeSource#secretRef
        /// </remarks>
        [JsiiProperty(name: "secretRef", typeJson: "{\"fqn\":\"k8s.LocalObjectReference\"}")]
        K8s.ILocalObjectReference SecretRef
        {
            get;
        }

        /// <summary>system is the name of the storage system as configured in ScaleIO.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ScaleIOVolumeSource#system
        /// </remarks>
        [JsiiProperty(name: "system", typeJson: "{\"primitive\":\"string\"}")]
        string System
        {
            get;
        }

        /// <summary>fsType is the filesystem type to mount.</summary>
        /// <remarks>
        /// Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". Default is "xfs".
        ///
        /// <strong>Default</strong>: xfs".
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ScaleIOVolumeSource#fsType
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

        /// <summary>protectionDomain is the name of the ScaleIO Protection Domain for the configured storage.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ScaleIOVolumeSource#protectionDomain
        /// </remarks>
        [JsiiProperty(name: "protectionDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProtectionDomain
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
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ScaleIOVolumeSource#readOnly
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

        /// <summary>sslEnabled Flag enable/disable SSL communication with Gateway, default false.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ScaleIOVolumeSource#sslEnabled
        /// </remarks>
        [JsiiProperty(name: "sslEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? SslEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>storageMode indicates whether the storage for a volume should be ThickProvisioned or ThinProvisioned.</summary>
        /// <remarks>
        /// Default is ThinProvisioned.
        ///
        /// <strong>Default</strong>: ThinProvisioned.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ScaleIOVolumeSource#storageMode
        /// </remarks>
        [JsiiProperty(name: "storageMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StorageMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>storagePool is the ScaleIO Storage Pool associated with the protection domain.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ScaleIOVolumeSource#storagePool
        /// </remarks>
        [JsiiProperty(name: "storagePool", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StoragePool
        {
            get
            {
                return null;
            }
        }

        /// <summary>volumeName is the name of a volume already created in the ScaleIO system that is associated with this volume source.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ScaleIOVolumeSource#volumeName
        /// </remarks>
        [JsiiProperty(name: "volumeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VolumeName
        {
            get
            {
                return null;
            }
        }

        /// <summary>ScaleIOVolumeSource represents a persistent ScaleIO volume.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ScaleIOVolumeSource
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IScaleIoVolumeSource), fullyQualifiedName: "k8s.ScaleIoVolumeSource")]
        internal sealed class _Proxy : DeputyBase, K8s.IScaleIoVolumeSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>gateway is the host address of the ScaleIO API Gateway.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ScaleIOVolumeSource#gateway
            /// </remarks>
            [JsiiProperty(name: "gateway", typeJson: "{\"primitive\":\"string\"}")]
            public string Gateway
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>secretRef references to the secret for ScaleIO user and other sensitive information.</summary>
            /// <remarks>
            /// If this is not provided, Login operation will fail.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ScaleIOVolumeSource#secretRef
            /// </remarks>
            [JsiiProperty(name: "secretRef", typeJson: "{\"fqn\":\"k8s.LocalObjectReference\"}")]
            public K8s.ILocalObjectReference SecretRef
            {
                get => GetInstanceProperty<K8s.ILocalObjectReference>()!;
            }

            /// <summary>system is the name of the storage system as configured in ScaleIO.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ScaleIOVolumeSource#system
            /// </remarks>
            [JsiiProperty(name: "system", typeJson: "{\"primitive\":\"string\"}")]
            public string System
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>fsType is the filesystem type to mount.</summary>
            /// <remarks>
            /// Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". Default is "xfs".
            ///
            /// <strong>Default</strong>: xfs".
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ScaleIOVolumeSource#fsType
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fsType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FsType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>protectionDomain is the name of the ScaleIO Protection Domain for the configured storage.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ScaleIOVolumeSource#protectionDomain
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "protectionDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProtectionDomain
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>readOnly Defaults to false (read/write).</summary>
            /// <remarks>
            /// ReadOnly here will force the ReadOnly setting in VolumeMounts.
            ///
            /// <strong>Default</strong>: false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ScaleIOVolumeSource#readOnly
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "readOnly", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? ReadOnly
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>sslEnabled Flag enable/disable SSL communication with Gateway, default false.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ScaleIOVolumeSource#sslEnabled
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sslEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? SslEnabled
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>storageMode indicates whether the storage for a volume should be ThickProvisioned or ThinProvisioned.</summary>
            /// <remarks>
            /// Default is ThinProvisioned.
            ///
            /// <strong>Default</strong>: ThinProvisioned.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ScaleIOVolumeSource#storageMode
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StorageMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>storagePool is the ScaleIO Storage Pool associated with the protection domain.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ScaleIOVolumeSource#storagePool
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storagePool", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StoragePool
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>volumeName is the name of a volume already created in the ScaleIO system that is associated with this volume source.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ScaleIOVolumeSource#volumeName
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "volumeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VolumeName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
