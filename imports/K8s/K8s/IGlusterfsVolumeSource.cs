using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Represents a Glusterfs mount that lasts the lifetime of a pod.</summary>
    /// <remarks>
    /// Glusterfs volumes do not support ownership management or SELinux relabeling.
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.GlusterfsVolumeSource
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IGlusterfsVolumeSource), fullyQualifiedName: "k8s.GlusterfsVolumeSource")]
    public interface IGlusterfsVolumeSource
    {
        /// <summary>endpoints is the endpoint name that details Glusterfs topology.</summary>
        /// <remarks>
        /// More info: https://examples.k8s.io/volumes/glusterfs/README.md#create-a-pod
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.GlusterfsVolumeSource#endpoints
        /// </remarks>
        [JsiiProperty(name: "endpoints", typeJson: "{\"primitive\":\"string\"}")]
        string Endpoints
        {
            get;
        }

        /// <summary>path is the Glusterfs volume path.</summary>
        /// <remarks>
        /// More info: https://examples.k8s.io/volumes/glusterfs/README.md#create-a-pod
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.GlusterfsVolumeSource#path
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        string Path
        {
            get;
        }

        /// <summary>readOnly here will force the Glusterfs volume to be mounted with read-only permissions.</summary>
        /// <remarks>
        /// Defaults to false. More info: https://examples.k8s.io/volumes/glusterfs/README.md#create-a-pod
        ///
        /// <strong>Default</strong>: false. More info: https://examples.k8s.io/volumes/glusterfs/README.md#create-a-pod
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.GlusterfsVolumeSource#readOnly
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

        /// <summary>Represents a Glusterfs mount that lasts the lifetime of a pod.</summary>
        /// <remarks>
        /// Glusterfs volumes do not support ownership management or SELinux relabeling.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.GlusterfsVolumeSource
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IGlusterfsVolumeSource), fullyQualifiedName: "k8s.GlusterfsVolumeSource")]
        internal sealed class _Proxy : DeputyBase, K8s.IGlusterfsVolumeSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>endpoints is the endpoint name that details Glusterfs topology.</summary>
            /// <remarks>
            /// More info: https://examples.k8s.io/volumes/glusterfs/README.md#create-a-pod
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.GlusterfsVolumeSource#endpoints
            /// </remarks>
            [JsiiProperty(name: "endpoints", typeJson: "{\"primitive\":\"string\"}")]
            public string Endpoints
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>path is the Glusterfs volume path.</summary>
            /// <remarks>
            /// More info: https://examples.k8s.io/volumes/glusterfs/README.md#create-a-pod
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.GlusterfsVolumeSource#path
            /// </remarks>
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
            public string Path
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>readOnly here will force the Glusterfs volume to be mounted with read-only permissions.</summary>
            /// <remarks>
            /// Defaults to false. More info: https://examples.k8s.io/volumes/glusterfs/README.md#create-a-pod
            ///
            /// <strong>Default</strong>: false. More info: https://examples.k8s.io/volumes/glusterfs/README.md#create-a-pod
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.GlusterfsVolumeSource#readOnly
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "readOnly", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? ReadOnly
            {
                get => GetInstanceProperty<bool?>();
            }
        }
    }
}
