using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Represents a host path mapped into a pod.</summary>
    /// <remarks>
    /// Host path volumes do not support ownership management or SELinux relabeling.
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.HostPathVolumeSource
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IHostPathVolumeSource), fullyQualifiedName: "k8s.HostPathVolumeSource")]
    public interface IHostPathVolumeSource
    {
        /// <summary>path of the directory on the host.</summary>
        /// <remarks>
        /// If the path is a symlink, it will follow the link to the real path. More info: https://kubernetes.io/docs/concepts/storage/volumes#hostpath
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.HostPathVolumeSource#path
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        string Path
        {
            get;
        }

        /// <summary>type for HostPath Volume Defaults to "" More info: https://kubernetes.io/docs/concepts/storage/volumes#hostpath.</summary>
        /// <remarks>
        /// <strong>Default</strong>: More info: https://kubernetes.io/docs/concepts/storage/volumes#hostpath
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.HostPathVolumeSource#type
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        /// <summary>Represents a host path mapped into a pod.</summary>
        /// <remarks>
        /// Host path volumes do not support ownership management or SELinux relabeling.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.HostPathVolumeSource
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IHostPathVolumeSource), fullyQualifiedName: "k8s.HostPathVolumeSource")]
        internal sealed class _Proxy : DeputyBase, K8s.IHostPathVolumeSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>path of the directory on the host.</summary>
            /// <remarks>
            /// If the path is a symlink, it will follow the link to the real path. More info: https://kubernetes.io/docs/concepts/storage/volumes#hostpath
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.HostPathVolumeSource#path
            /// </remarks>
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
            public string Path
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>type for HostPath Volume Defaults to "" More info: https://kubernetes.io/docs/concepts/storage/volumes#hostpath.</summary>
            /// <remarks>
            /// <strong>Default</strong>: More info: https://kubernetes.io/docs/concepts/storage/volumes#hostpath
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.HostPathVolumeSource#type
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
