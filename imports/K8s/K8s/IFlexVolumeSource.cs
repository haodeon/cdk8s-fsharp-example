using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>FlexVolume represents a generic volume resource that is provisioned/attached using an exec based plugin.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.FlexVolumeSource
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IFlexVolumeSource), fullyQualifiedName: "k8s.FlexVolumeSource")]
    public interface IFlexVolumeSource
    {
        /// <summary>driver is the name of the driver to use for this volume.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.FlexVolumeSource#driver
        /// </remarks>
        [JsiiProperty(name: "driver", typeJson: "{\"primitive\":\"string\"}")]
        string Driver
        {
            get;
        }

        /// <summary>fsType is the filesystem type to mount.</summary>
        /// <remarks>
        /// Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". The default filesystem depends on FlexVolume script.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.FlexVolumeSource#fsType
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

        /// <summary>options is Optional: this field holds extra command options if any.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.FlexVolumeSource#options
        /// </remarks>
        [JsiiProperty(name: "options", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Options
        {
            get
            {
                return null;
            }
        }

        /// <summary>readOnly is Optional: defaults to false (read/write).</summary>
        /// <remarks>
        /// ReadOnly here will force the ReadOnly setting in VolumeMounts.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.FlexVolumeSource#readOnly
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

        /// <summary>secretRef is Optional: secretRef is reference to the secret object containing sensitive information to pass to the plugin scripts.</summary>
        /// <remarks>
        /// This may be empty if no secret object is specified. If the secret object contains more than one secret, all secrets are passed to the plugin scripts.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.FlexVolumeSource#secretRef
        /// </remarks>
        [JsiiProperty(name: "secretRef", typeJson: "{\"fqn\":\"k8s.LocalObjectReference\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ILocalObjectReference? SecretRef
        {
            get
            {
                return null;
            }
        }

        /// <summary>FlexVolume represents a generic volume resource that is provisioned/attached using an exec based plugin.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.FlexVolumeSource
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IFlexVolumeSource), fullyQualifiedName: "k8s.FlexVolumeSource")]
        internal sealed class _Proxy : DeputyBase, K8s.IFlexVolumeSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>driver is the name of the driver to use for this volume.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.FlexVolumeSource#driver
            /// </remarks>
            [JsiiProperty(name: "driver", typeJson: "{\"primitive\":\"string\"}")]
            public string Driver
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>fsType is the filesystem type to mount.</summary>
            /// <remarks>
            /// Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". The default filesystem depends on FlexVolume script.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.FlexVolumeSource#fsType
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fsType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FsType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>options is Optional: this field holds extra command options if any.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.FlexVolumeSource#options
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "options", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Options
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>readOnly is Optional: defaults to false (read/write).</summary>
            /// <remarks>
            /// ReadOnly here will force the ReadOnly setting in VolumeMounts.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.FlexVolumeSource#readOnly
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "readOnly", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? ReadOnly
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>secretRef is Optional: secretRef is reference to the secret object containing sensitive information to pass to the plugin scripts.</summary>
            /// <remarks>
            /// This may be empty if no secret object is specified. If the secret object contains more than one secret, all secrets are passed to the plugin scripts.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.FlexVolumeSource#secretRef
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secretRef", typeJson: "{\"fqn\":\"k8s.LocalObjectReference\"}", isOptional: true)]
            public K8s.ILocalObjectReference? SecretRef
            {
                get => GetInstanceProperty<K8s.ILocalObjectReference?>();
            }
        }
    }
}
