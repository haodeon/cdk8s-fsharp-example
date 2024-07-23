using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>Represents a Ceph Filesystem mount that lasts the lifetime of a pod Cephfs volumes do not support ownership management or SELinux relabeling.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.CephFSPersistentVolumeSource
    /// </remarks>
    [JsiiByValue(fqn: "k8s.CephFsPersistentVolumeSource")]
    public class CephFsPersistentVolumeSource : K8s.ICephFsPersistentVolumeSource
    {
        /// <summary>monitors is Required: Monitors is a collection of Ceph monitors More info: https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.CephFSPersistentVolumeSource#monitors
        /// </remarks>
        [JsiiProperty(name: "monitors", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Monitors
        {
            get;
            set;
        }

        /// <summary>path is Optional: Used as the mounted root, rather than the full Ceph tree, default is /.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.CephFSPersistentVolumeSource#path
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Path
        {
            get;
            set;
        }

        /// <summary>readOnly is Optional: Defaults to false (read/write).</summary>
        /// <remarks>
        /// ReadOnly here will force the ReadOnly setting in VolumeMounts. More info: https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it
        ///
        /// <strong>Default</strong>: false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts. More info: https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.CephFSPersistentVolumeSource#readOnly
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "readOnly", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? ReadOnly
        {
            get;
            set;
        }

        /// <summary>secretFile is Optional: SecretFile is the path to key ring for User, default is /etc/ceph/user.secret More info: https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.CephFSPersistentVolumeSource#secretFile
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secretFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecretFile
        {
            get;
            set;
        }

        /// <summary>secretRef is Optional: SecretRef is reference to the authentication secret for User, default is empty.</summary>
        /// <remarks>
        /// More info: https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.CephFSPersistentVolumeSource#secretRef
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secretRef", typeJson: "{\"fqn\":\"k8s.SecretReference\"}", isOptional: true)]
        public K8s.ISecretReference? SecretRef
        {
            get;
            set;
        }

        /// <summary>user is Optional: User is the rados user name, default is admin More info: https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.CephFSPersistentVolumeSource#user
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "user", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? User
        {
            get;
            set;
        }
    }
}
