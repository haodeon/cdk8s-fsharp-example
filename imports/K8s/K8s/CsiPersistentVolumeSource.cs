using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>Represents storage that is managed by an external CSI volume driver (Beta feature).</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.CSIPersistentVolumeSource
    /// </remarks>
    [JsiiByValue(fqn: "k8s.CsiPersistentVolumeSource")]
    public class CsiPersistentVolumeSource : K8s.ICsiPersistentVolumeSource
    {
        /// <summary>driver is the name of the driver to use for this volume.</summary>
        /// <remarks>
        /// Required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.CSIPersistentVolumeSource#driver
        /// </remarks>
        [JsiiProperty(name: "driver", typeJson: "{\"primitive\":\"string\"}")]
        public string Driver
        {
            get;
            set;
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
            get;
            set;
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
            get;
            set;
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
            get;
            set;
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
            get;
            set;
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
            get;
            set;
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
            get;
            set;
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
            get;
            set;
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
            get;
            set;
        }

        /// <summary>volumeAttributes of the volume to publish.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.CSIPersistentVolumeSource#volumeAttributes
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "volumeAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? VolumeAttributes
        {
            get;
            set;
        }
    }
}
