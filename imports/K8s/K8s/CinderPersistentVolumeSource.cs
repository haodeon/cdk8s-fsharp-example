using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>Represents a cinder volume resource in Openstack.</summary>
    /// <remarks>
    /// A Cinder volume must exist before mounting to a container. The volume must also be in the same region as the kubelet. Cinder volumes support ownership management and SELinux relabeling.
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.CinderPersistentVolumeSource
    /// </remarks>
    [JsiiByValue(fqn: "k8s.CinderPersistentVolumeSource")]
    public class CinderPersistentVolumeSource : K8s.ICinderPersistentVolumeSource
    {
        /// <summary>volumeID used to identify the volume in cinder.</summary>
        /// <remarks>
        /// More info: https://examples.k8s.io/mysql-cinder-pd/README.md
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.CinderPersistentVolumeSource#volumeID
        /// </remarks>
        [JsiiProperty(name: "volumeId", typeJson: "{\"primitive\":\"string\"}")]
        public string VolumeId
        {
            get;
            set;
        }

        /// <summary>fsType Filesystem type to mount.</summary>
        /// <remarks>
        /// Must be a filesystem type supported by the host operating system. Examples: "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified. More info: https://examples.k8s.io/mysql-cinder-pd/README.md
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.CinderPersistentVolumeSource#fsType
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fsType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FsType
        {
            get;
            set;
        }

        /// <summary>readOnly is Optional: Defaults to false (read/write).</summary>
        /// <remarks>
        /// ReadOnly here will force the ReadOnly setting in VolumeMounts. More info: https://examples.k8s.io/mysql-cinder-pd/README.md
        ///
        /// <strong>Default</strong>: false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts. More info: https://examples.k8s.io/mysql-cinder-pd/README.md
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.CinderPersistentVolumeSource#readOnly
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "readOnly", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? ReadOnly
        {
            get;
            set;
        }

        /// <summary>secretRef is Optional: points to a secret object containing parameters used to connect to OpenStack.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.CinderPersistentVolumeSource#secretRef
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secretRef", typeJson: "{\"fqn\":\"k8s.SecretReference\"}", isOptional: true)]
        public K8s.ISecretReference? SecretRef
        {
            get;
            set;
        }
    }
}