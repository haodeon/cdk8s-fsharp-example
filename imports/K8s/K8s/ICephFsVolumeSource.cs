using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Represents a Ceph Filesystem mount that lasts the lifetime of a pod Cephfs volumes do not support ownership management or SELinux relabeling.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.CephFSVolumeSource
    /// </remarks>
    [JsiiInterface(nativeType: typeof(ICephFsVolumeSource), fullyQualifiedName: "k8s.CephFsVolumeSource")]
    public interface ICephFsVolumeSource
    {
        /// <summary>monitors is Required: Monitors is a collection of Ceph monitors More info: https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.CephFSVolumeSource#monitors
        /// </remarks>
        [JsiiProperty(name: "monitors", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Monitors
        {
            get;
        }

        /// <summary>path is Optional: Used as the mounted root, rather than the full Ceph tree, default is /.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.CephFSVolumeSource#path
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Path
        {
            get
            {
                return null;
            }
        }

        /// <summary>readOnly is Optional: Defaults to false (read/write).</summary>
        /// <remarks>
        /// ReadOnly here will force the ReadOnly setting in VolumeMounts. More info: https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it
        ///
        /// <strong>Default</strong>: false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts. More info: https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.CephFSVolumeSource#readOnly
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

        /// <summary>secretFile is Optional: SecretFile is the path to key ring for User, default is /etc/ceph/user.secret More info: https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.CephFSVolumeSource#secretFile
        /// </remarks>
        [JsiiProperty(name: "secretFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecretFile
        {
            get
            {
                return null;
            }
        }

        /// <summary>secretRef is Optional: SecretRef is reference to the authentication secret for User, default is empty.</summary>
        /// <remarks>
        /// More info: https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.CephFSVolumeSource#secretRef
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

        /// <summary>user is optional: User is the rados user name, default is admin More info: https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.CephFSVolumeSource#user
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

        /// <summary>Represents a Ceph Filesystem mount that lasts the lifetime of a pod Cephfs volumes do not support ownership management or SELinux relabeling.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.CephFSVolumeSource
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(ICephFsVolumeSource), fullyQualifiedName: "k8s.CephFsVolumeSource")]
        internal sealed class _Proxy : DeputyBase, K8s.ICephFsVolumeSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>monitors is Required: Monitors is a collection of Ceph monitors More info: https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.CephFSVolumeSource#monitors
            /// </remarks>
            [JsiiProperty(name: "monitors", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Monitors
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>path is Optional: Used as the mounted root, rather than the full Ceph tree, default is /.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.CephFSVolumeSource#path
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Path
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>readOnly is Optional: Defaults to false (read/write).</summary>
            /// <remarks>
            /// ReadOnly here will force the ReadOnly setting in VolumeMounts. More info: https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it
            ///
            /// <strong>Default</strong>: false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts. More info: https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.CephFSVolumeSource#readOnly
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "readOnly", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? ReadOnly
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>secretFile is Optional: SecretFile is the path to key ring for User, default is /etc/ceph/user.secret More info: https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.CephFSVolumeSource#secretFile
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secretFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecretFile
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>secretRef is Optional: SecretRef is reference to the authentication secret for User, default is empty.</summary>
            /// <remarks>
            /// More info: https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.CephFSVolumeSource#secretRef
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secretRef", typeJson: "{\"fqn\":\"k8s.LocalObjectReference\"}", isOptional: true)]
            public K8s.ILocalObjectReference? SecretRef
            {
                get => GetInstanceProperty<K8s.ILocalObjectReference?>();
            }

            /// <summary>user is optional: User is the rados user name, default is admin More info: https://examples.k8s.io/volumes/cephfs/README.md#how-to-use-it.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.CephFSVolumeSource#user
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
