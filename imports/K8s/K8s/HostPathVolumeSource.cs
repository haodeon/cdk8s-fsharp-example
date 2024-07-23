using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>Represents a host path mapped into a pod.</summary>
    /// <remarks>
    /// Host path volumes do not support ownership management or SELinux relabeling.
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.HostPathVolumeSource
    /// </remarks>
    [JsiiByValue(fqn: "k8s.HostPathVolumeSource")]
    public class HostPathVolumeSource : K8s.IHostPathVolumeSource
    {
        /// <summary>path of the directory on the host.</summary>
        /// <remarks>
        /// If the path is a symlink, it will follow the link to the real path. More info: https://kubernetes.io/docs/concepts/storage/volumes#hostpath
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.HostPathVolumeSource#path
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public string Path
        {
            get;
            set;
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
            get;
            set;
        }
    }
}
