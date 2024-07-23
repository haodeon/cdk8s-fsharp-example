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
    [JsiiInterface(nativeType: typeof(IFcVolumeSource), fullyQualifiedName: "k8s.FcVolumeSource")]
    public interface IFcVolumeSource
    {
        /// <summary>fsType is the filesystem type to mount.</summary>
        /// <remarks>
        /// Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.FCVolumeSource#fsType
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

        /// <summary>lun is Optional: FC target lun number.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.FCVolumeSource#lun
        /// </remarks>
        [JsiiProperty(name: "lun", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Lun
        {
            get
            {
                return null;
            }
        }

        /// <summary>readOnly is Optional: Defaults to false (read/write).</summary>
        /// <remarks>
        /// ReadOnly here will force the ReadOnly setting in VolumeMounts.
        ///
        /// <strong>Default</strong>: false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.FCVolumeSource#readOnly
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

        /// <summary>targetWWNs is Optional: FC target worldwide names (WWNs).</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.FCVolumeSource#targetWWNs
        /// </remarks>
        [JsiiProperty(name: "targetWwNs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? TargetWwNs
        {
            get
            {
                return null;
            }
        }

        /// <summary>wwids Optional: FC volume world wide identifiers (wwids) Either wwids or combination of targetWWNs and lun must be set, but not both simultaneously.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.FCVolumeSource#wwids
        /// </remarks>
        [JsiiProperty(name: "wwids", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Wwids
        {
            get
            {
                return null;
            }
        }

        /// <summary>Represents a Fibre Channel volume.</summary>
        /// <remarks>
        /// Fibre Channel volumes can only be mounted as read/write once. Fibre Channel volumes support ownership management and SELinux relabeling.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.FCVolumeSource
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IFcVolumeSource), fullyQualifiedName: "k8s.FcVolumeSource")]
        internal sealed class _Proxy : DeputyBase, K8s.IFcVolumeSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

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
                get => GetInstanceProperty<string?>();
            }

            /// <summary>lun is Optional: FC target lun number.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.FCVolumeSource#lun
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lun", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Lun
            {
                get => GetInstanceProperty<double?>();
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
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>targetWWNs is Optional: FC target worldwide names (WWNs).</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.FCVolumeSource#targetWWNs
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "targetWwNs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? TargetWwNs
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>wwids Optional: FC volume world wide identifiers (wwids) Either wwids or combination of targetWWNs and lun must be set, but not both simultaneously.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.FCVolumeSource#wwids
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "wwids", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Wwids
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
