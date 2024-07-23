using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Represents a Rados Block Device mount that lasts the lifetime of a pod.</summary>
    /// <remarks>
    /// RBD volumes support ownership management and SELinux relabeling.
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.RBDPersistentVolumeSource
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IRbdPersistentVolumeSource), fullyQualifiedName: "k8s.RbdPersistentVolumeSource")]
    public interface IRbdPersistentVolumeSource
    {
        /// <summary>image is the rados image name.</summary>
        /// <remarks>
        /// More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.RBDPersistentVolumeSource#image
        /// </remarks>
        [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}")]
        string Image
        {
            get;
        }

        /// <summary>monitors is a collection of Ceph monitors.</summary>
        /// <remarks>
        /// More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.RBDPersistentVolumeSource#monitors
        /// </remarks>
        [JsiiProperty(name: "monitors", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Monitors
        {
            get;
        }

        /// <summary>fsType is the filesystem type of the volume that you want to mount.</summary>
        /// <remarks>
        /// Tip: Ensure that the filesystem type is supported by the host operating system. Examples: "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified. More info: https://kubernetes.io/docs/concepts/storage/volumes#rbd
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.RBDPersistentVolumeSource#fsType
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

        /// <summary>keyring is the path to key ring for RBDUser.</summary>
        /// <remarks>
        /// Default is /etc/ceph/keyring. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it
        ///
        /// <strong>Default</strong>: etc/ceph/keyring. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.RBDPersistentVolumeSource#keyring
        /// </remarks>
        [JsiiProperty(name: "keyring", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Keyring
        {
            get
            {
                return null;
            }
        }

        /// <summary>pool is the rados pool name.</summary>
        /// <remarks>
        /// Default is rbd. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it
        ///
        /// <strong>Default</strong>: rbd. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.RBDPersistentVolumeSource#pool
        /// </remarks>
        [JsiiProperty(name: "pool", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Pool
        {
            get
            {
                return null;
            }
        }

        /// <summary>readOnly here will force the ReadOnly setting in VolumeMounts.</summary>
        /// <remarks>
        /// Defaults to false. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it
        ///
        /// <strong>Default</strong>: false. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.RBDPersistentVolumeSource#readOnly
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

        /// <summary>secretRef is name of the authentication secret for RBDUser.</summary>
        /// <remarks>
        /// If provided overrides keyring. Default is nil. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it
        ///
        /// <strong>Default</strong>: nil. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.RBDPersistentVolumeSource#secretRef
        /// </remarks>
        [JsiiProperty(name: "secretRef", typeJson: "{\"fqn\":\"k8s.SecretReference\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ISecretReference? SecretRef
        {
            get
            {
                return null;
            }
        }

        /// <summary>user is the rados user name.</summary>
        /// <remarks>
        /// Default is admin. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it
        ///
        /// <strong>Default</strong>: admin. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.RBDPersistentVolumeSource#user
        /// </remarks>
        [JsiiProperty(name: "user", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? User
        {
            get
            {
                return null;
            }
        }

        /// <summary>Represents a Rados Block Device mount that lasts the lifetime of a pod.</summary>
        /// <remarks>
        /// RBD volumes support ownership management and SELinux relabeling.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.RBDPersistentVolumeSource
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IRbdPersistentVolumeSource), fullyQualifiedName: "k8s.RbdPersistentVolumeSource")]
        internal sealed class _Proxy : DeputyBase, K8s.IRbdPersistentVolumeSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>image is the rados image name.</summary>
            /// <remarks>
            /// More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.RBDPersistentVolumeSource#image
            /// </remarks>
            [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}")]
            public string Image
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>monitors is a collection of Ceph monitors.</summary>
            /// <remarks>
            /// More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.RBDPersistentVolumeSource#monitors
            /// </remarks>
            [JsiiProperty(name: "monitors", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Monitors
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>fsType is the filesystem type of the volume that you want to mount.</summary>
            /// <remarks>
            /// Tip: Ensure that the filesystem type is supported by the host operating system. Examples: "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified. More info: https://kubernetes.io/docs/concepts/storage/volumes#rbd
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.RBDPersistentVolumeSource#fsType
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fsType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FsType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>keyring is the path to key ring for RBDUser.</summary>
            /// <remarks>
            /// Default is /etc/ceph/keyring. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it
            ///
            /// <strong>Default</strong>: etc/ceph/keyring. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.RBDPersistentVolumeSource#keyring
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "keyring", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Keyring
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>pool is the rados pool name.</summary>
            /// <remarks>
            /// Default is rbd. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it
            ///
            /// <strong>Default</strong>: rbd. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.RBDPersistentVolumeSource#pool
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pool", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Pool
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>readOnly here will force the ReadOnly setting in VolumeMounts.</summary>
            /// <remarks>
            /// Defaults to false. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it
            ///
            /// <strong>Default</strong>: false. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.RBDPersistentVolumeSource#readOnly
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "readOnly", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? ReadOnly
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>secretRef is name of the authentication secret for RBDUser.</summary>
            /// <remarks>
            /// If provided overrides keyring. Default is nil. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it
            ///
            /// <strong>Default</strong>: nil. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.RBDPersistentVolumeSource#secretRef
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secretRef", typeJson: "{\"fqn\":\"k8s.SecretReference\"}", isOptional: true)]
            public K8s.ISecretReference? SecretRef
            {
                get => GetInstanceProperty<K8s.ISecretReference?>();
            }

            /// <summary>user is the rados user name.</summary>
            /// <remarks>
            /// Default is admin. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it
            ///
            /// <strong>Default</strong>: admin. More info: https://examples.k8s.io/volumes/rbd/README.md#how-to-use-it
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.RBDPersistentVolumeSource#user
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "user", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? User
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
