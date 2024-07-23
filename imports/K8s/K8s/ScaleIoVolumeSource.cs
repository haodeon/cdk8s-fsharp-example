using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>ScaleIOVolumeSource represents a persistent ScaleIO volume.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ScaleIOVolumeSource
    /// </remarks>
    [JsiiByValue(fqn: "k8s.ScaleIoVolumeSource")]
    public class ScaleIoVolumeSource : K8s.IScaleIoVolumeSource
    {
        /// <summary>gateway is the host address of the ScaleIO API Gateway.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ScaleIOVolumeSource#gateway
        /// </remarks>
        [JsiiProperty(name: "gateway", typeJson: "{\"primitive\":\"string\"}")]
        public string Gateway
        {
            get;
            set;
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
            get;
            set;
        }

        /// <summary>system is the name of the storage system as configured in ScaleIO.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ScaleIOVolumeSource#system
        /// </remarks>
        [JsiiProperty(name: "system", typeJson: "{\"primitive\":\"string\"}")]
        public string System
        {
            get;
            set;
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
            get;
            set;
        }

        /// <summary>protectionDomain is the name of the ScaleIO Protection Domain for the configured storage.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ScaleIOVolumeSource#protectionDomain
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "protectionDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProtectionDomain
        {
            get;
            set;
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
            get;
            set;
        }

        /// <summary>sslEnabled Flag enable/disable SSL communication with Gateway, default false.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ScaleIOVolumeSource#sslEnabled
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sslEnabled", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? SslEnabled
        {
            get;
            set;
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
            get;
            set;
        }

        /// <summary>storagePool is the ScaleIO Storage Pool associated with the protection domain.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ScaleIOVolumeSource#storagePool
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "storagePool", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StoragePool
        {
            get;
            set;
        }

        /// <summary>volumeName is the name of a volume already created in the ScaleIO system that is associated with this volume source.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ScaleIOVolumeSource#volumeName
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "volumeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VolumeName
        {
            get;
            set;
        }
    }
}
