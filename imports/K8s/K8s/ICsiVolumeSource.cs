using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Represents a source location of a volume to mount, managed by an external CSI driver.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.CSIVolumeSource
    /// </remarks>
    [JsiiInterface(nativeType: typeof(ICsiVolumeSource), fullyQualifiedName: "k8s.CsiVolumeSource")]
    public interface ICsiVolumeSource
    {
        /// <summary>driver is the name of the CSI driver that handles this volume.</summary>
        /// <remarks>
        /// Consult with your admin for the correct name as registered in the cluster.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.CSIVolumeSource#driver
        /// </remarks>
        [JsiiProperty(name: "driver", typeJson: "{\"primitive\":\"string\"}")]
        string Driver
        {
            get;
        }

        /// <summary>fsType to mount.</summary>
        /// <remarks>
        /// Ex. "ext4", "xfs", "ntfs". If not provided, the empty value is passed to the associated CSI driver which will determine the default filesystem to apply.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.CSIVolumeSource#fsType
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

        /// <summary>nodePublishSecretRef is a reference to the secret object containing sensitive information to pass to the CSI driver to complete the CSI NodePublishVolume and NodeUnpublishVolume calls.</summary>
        /// <remarks>
        /// This field is optional, and  may be empty if no secret is required. If the secret object contains more than one secret, all secret references are passed.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.CSIVolumeSource#nodePublishSecretRef
        /// </remarks>
        [JsiiProperty(name: "nodePublishSecretRef", typeJson: "{\"fqn\":\"k8s.LocalObjectReference\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ILocalObjectReference? NodePublishSecretRef
        {
            get
            {
                return null;
            }
        }

        /// <summary>readOnly specifies a read-only configuration for the volume.</summary>
        /// <remarks>
        /// Defaults to false (read/write).
        ///
        /// <strong>Default</strong>: false (read/write).
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.CSIVolumeSource#readOnly
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

        /// <summary>volumeAttributes stores driver-specific properties that are passed to the CSI driver.</summary>
        /// <remarks>
        /// Consult your driver's documentation for supported values.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.CSIVolumeSource#volumeAttributes
        /// </remarks>
        [JsiiProperty(name: "volumeAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? VolumeAttributes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Represents a source location of a volume to mount, managed by an external CSI driver.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.CSIVolumeSource
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(ICsiVolumeSource), fullyQualifiedName: "k8s.CsiVolumeSource")]
        internal sealed class _Proxy : DeputyBase, K8s.ICsiVolumeSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>driver is the name of the CSI driver that handles this volume.</summary>
            /// <remarks>
            /// Consult with your admin for the correct name as registered in the cluster.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.CSIVolumeSource#driver
            /// </remarks>
            [JsiiProperty(name: "driver", typeJson: "{\"primitive\":\"string\"}")]
            public string Driver
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>fsType to mount.</summary>
            /// <remarks>
            /// Ex. "ext4", "xfs", "ntfs". If not provided, the empty value is passed to the associated CSI driver which will determine the default filesystem to apply.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.CSIVolumeSource#fsType
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fsType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FsType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>nodePublishSecretRef is a reference to the secret object containing sensitive information to pass to the CSI driver to complete the CSI NodePublishVolume and NodeUnpublishVolume calls.</summary>
            /// <remarks>
            /// This field is optional, and  may be empty if no secret is required. If the secret object contains more than one secret, all secret references are passed.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.CSIVolumeSource#nodePublishSecretRef
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nodePublishSecretRef", typeJson: "{\"fqn\":\"k8s.LocalObjectReference\"}", isOptional: true)]
            public K8s.ILocalObjectReference? NodePublishSecretRef
            {
                get => GetInstanceProperty<K8s.ILocalObjectReference?>();
            }

            /// <summary>readOnly specifies a read-only configuration for the volume.</summary>
            /// <remarks>
            /// Defaults to false (read/write).
            ///
            /// <strong>Default</strong>: false (read/write).
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.CSIVolumeSource#readOnly
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "readOnly", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? ReadOnly
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>volumeAttributes stores driver-specific properties that are passed to the CSI driver.</summary>
            /// <remarks>
            /// Consult your driver's documentation for supported values.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.CSIVolumeSource#volumeAttributes
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "volumeAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? VolumeAttributes
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }
        }
    }
}
