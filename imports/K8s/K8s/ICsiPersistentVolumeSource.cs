using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Represents storage that is managed by an external CSI volume driver (Beta feature).</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.CSIPersistentVolumeSource
    /// </remarks>
    [JsiiInterface(nativeType: typeof(ICsiPersistentVolumeSource), fullyQualifiedName: "k8s.CsiPersistentVolumeSource")]
    public interface ICsiPersistentVolumeSource
    {
        /// <summary>driver is the name of the driver to use for this volume.</summary>
        /// <remarks>
        /// Required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.CSIPersistentVolumeSource#driver
        /// </remarks>
        [JsiiProperty(name: "driver", typeJson: "{\"primitive\":\"string\"}")]
        string Driver
        {
            get;
        }

        /// <summary>volumeHandle is the unique volume name returned by the CSI volume plugin’s CreateVolume to refer to the volume on all subsequent calls.</summary>
        /// <remarks>
        /// Required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.CSIPersistentVolumeSource#volumeHandle
        /// </remarks>
        [JsiiProperty(name: "volumeHandle", typeJson: "{\"primitive\":\"string\"}")]
        string VolumeHandle
        {
            get;
        }

        /// <summary>controllerExpandSecretRef is a reference to the secret object containing sensitive information to pass to the CSI driver to complete the CSI ControllerExpandVolume call.</summary>
        /// <remarks>
        /// This field is optional, and may be empty if no secret is required. If the secret object contains more than one secret, all secrets are passed.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.CSIPersistentVolumeSource#controllerExpandSecretRef
        /// </remarks>
        [JsiiProperty(name: "controllerExpandSecretRef", typeJson: "{\"fqn\":\"k8s.SecretReference\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ISecretReference? ControllerExpandSecretRef
        {
            get
            {
                return null;
            }
        }

        /// <summary>controllerPublishSecretRef is a reference to the secret object containing sensitive information to pass to the CSI driver to complete the CSI ControllerPublishVolume and ControllerUnpublishVolume calls.</summary>
        /// <remarks>
        /// This field is optional, and may be empty if no secret is required. If the secret object contains more than one secret, all secrets are passed.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.CSIPersistentVolumeSource#controllerPublishSecretRef
        /// </remarks>
        [JsiiProperty(name: "controllerPublishSecretRef", typeJson: "{\"fqn\":\"k8s.SecretReference\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ISecretReference? ControllerPublishSecretRef
        {
            get
            {
                return null;
            }
        }

        /// <summary>fsType to mount.</summary>
        /// <remarks>
        /// Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs".
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.CSIPersistentVolumeSource#fsType
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

        /// <summary>nodeExpandSecretRef is a reference to the secret object containing sensitive information to pass to the CSI driver to complete the CSI NodeExpandVolume call.</summary>
        /// <remarks>
        /// This field is optional, may be omitted if no secret is required. If the secret object contains more than one secret, all secrets are passed.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.CSIPersistentVolumeSource#nodeExpandSecretRef
        /// </remarks>
        [JsiiProperty(name: "nodeExpandSecretRef", typeJson: "{\"fqn\":\"k8s.SecretReference\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ISecretReference? NodeExpandSecretRef
        {
            get
            {
                return null;
            }
        }

        /// <summary>nodePublishSecretRef is a reference to the secret object containing sensitive information to pass to the CSI driver to complete the CSI NodePublishVolume and NodeUnpublishVolume calls.</summary>
        /// <remarks>
        /// This field is optional, and may be empty if no secret is required. If the secret object contains more than one secret, all secrets are passed.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.CSIPersistentVolumeSource#nodePublishSecretRef
        /// </remarks>
        [JsiiProperty(name: "nodePublishSecretRef", typeJson: "{\"fqn\":\"k8s.SecretReference\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ISecretReference? NodePublishSecretRef
        {
            get
            {
                return null;
            }
        }

        /// <summary>nodeStageSecretRef is a reference to the secret object containing sensitive information to pass to the CSI driver to complete the CSI NodeStageVolume and NodeStageVolume and NodeUnstageVolume calls.</summary>
        /// <remarks>
        /// This field is optional, and may be empty if no secret is required. If the secret object contains more than one secret, all secrets are passed.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.CSIPersistentVolumeSource#nodeStageSecretRef
        /// </remarks>
        [JsiiProperty(name: "nodeStageSecretRef", typeJson: "{\"fqn\":\"k8s.SecretReference\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ISecretReference? NodeStageSecretRef
        {
            get
            {
                return null;
            }
        }

        /// <summary>readOnly value to pass to ControllerPublishVolumeRequest.</summary>
        /// <remarks>
        /// Defaults to false (read/write).
        ///
        /// <strong>Default</strong>: false (read/write).
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.CSIPersistentVolumeSource#readOnly
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

        /// <summary>volumeAttributes of the volume to publish.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.CSIPersistentVolumeSource#volumeAttributes
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

        /// <summary>Represents storage that is managed by an external CSI volume driver (Beta feature).</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.CSIPersistentVolumeSource
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(ICsiPersistentVolumeSource), fullyQualifiedName: "k8s.CsiPersistentVolumeSource")]
        internal sealed class _Proxy : DeputyBase, K8s.ICsiPersistentVolumeSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>driver is the name of the driver to use for this volume.</summary>
            /// <remarks>
            /// Required.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.CSIPersistentVolumeSource#driver
            /// </remarks>
            [JsiiProperty(name: "driver", typeJson: "{\"primitive\":\"string\"}")]
            public string Driver
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>volumeHandle is the unique volume name returned by the CSI volume plugin’s CreateVolume to refer to the volume on all subsequent calls.</summary>
            /// <remarks>
            /// Required.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.CSIPersistentVolumeSource#volumeHandle
            /// </remarks>
            [JsiiProperty(name: "volumeHandle", typeJson: "{\"primitive\":\"string\"}")]
            public string VolumeHandle
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>controllerExpandSecretRef is a reference to the secret object containing sensitive information to pass to the CSI driver to complete the CSI ControllerExpandVolume call.</summary>
            /// <remarks>
            /// This field is optional, and may be empty if no secret is required. If the secret object contains more than one secret, all secrets are passed.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.CSIPersistentVolumeSource#controllerExpandSecretRef
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "controllerExpandSecretRef", typeJson: "{\"fqn\":\"k8s.SecretReference\"}", isOptional: true)]
            public K8s.ISecretReference? ControllerExpandSecretRef
            {
                get => GetInstanceProperty<K8s.ISecretReference?>();
            }

            /// <summary>controllerPublishSecretRef is a reference to the secret object containing sensitive information to pass to the CSI driver to complete the CSI ControllerPublishVolume and ControllerUnpublishVolume calls.</summary>
            /// <remarks>
            /// This field is optional, and may be empty if no secret is required. If the secret object contains more than one secret, all secrets are passed.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.CSIPersistentVolumeSource#controllerPublishSecretRef
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "controllerPublishSecretRef", typeJson: "{\"fqn\":\"k8s.SecretReference\"}", isOptional: true)]
            public K8s.ISecretReference? ControllerPublishSecretRef
            {
                get => GetInstanceProperty<K8s.ISecretReference?>();
            }

            /// <summary>fsType to mount.</summary>
            /// <remarks>
            /// Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs".
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.CSIPersistentVolumeSource#fsType
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fsType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FsType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>nodeExpandSecretRef is a reference to the secret object containing sensitive information to pass to the CSI driver to complete the CSI NodeExpandVolume call.</summary>
            /// <remarks>
            /// This field is optional, may be omitted if no secret is required. If the secret object contains more than one secret, all secrets are passed.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.CSIPersistentVolumeSource#nodeExpandSecretRef
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nodeExpandSecretRef", typeJson: "{\"fqn\":\"k8s.SecretReference\"}", isOptional: true)]
            public K8s.ISecretReference? NodeExpandSecretRef
            {
                get => GetInstanceProperty<K8s.ISecretReference?>();
            }

            /// <summary>nodePublishSecretRef is a reference to the secret object containing sensitive information to pass to the CSI driver to complete the CSI NodePublishVolume and NodeUnpublishVolume calls.</summary>
            /// <remarks>
            /// This field is optional, and may be empty if no secret is required. If the secret object contains more than one secret, all secrets are passed.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.CSIPersistentVolumeSource#nodePublishSecretRef
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nodePublishSecretRef", typeJson: "{\"fqn\":\"k8s.SecretReference\"}", isOptional: true)]
            public K8s.ISecretReference? NodePublishSecretRef
            {
                get => GetInstanceProperty<K8s.ISecretReference?>();
            }

            /// <summary>nodeStageSecretRef is a reference to the secret object containing sensitive information to pass to the CSI driver to complete the CSI NodeStageVolume and NodeStageVolume and NodeUnstageVolume calls.</summary>
            /// <remarks>
            /// This field is optional, and may be empty if no secret is required. If the secret object contains more than one secret, all secrets are passed.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.CSIPersistentVolumeSource#nodeStageSecretRef
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nodeStageSecretRef", typeJson: "{\"fqn\":\"k8s.SecretReference\"}", isOptional: true)]
            public K8s.ISecretReference? NodeStageSecretRef
            {
                get => GetInstanceProperty<K8s.ISecretReference?>();
            }

            /// <summary>readOnly value to pass to ControllerPublishVolumeRequest.</summary>
            /// <remarks>
            /// Defaults to false (read/write).
            ///
            /// <strong>Default</strong>: false (read/write).
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.CSIPersistentVolumeSource#readOnly
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "readOnly", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? ReadOnly
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>volumeAttributes of the volume to publish.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.CSIPersistentVolumeSource#volumeAttributes
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
