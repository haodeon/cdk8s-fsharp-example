using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>Represents an NFS mount that lasts the lifetime of a pod.</summary>
    /// <remarks>
    /// NFS volumes do not support ownership management or SELinux relabeling.
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.NFSVolumeSource
    /// </remarks>
    [JsiiByValue(fqn: "k8s.NfsVolumeSource")]
    public class NfsVolumeSource : K8s.INfsVolumeSource
    {
        /// <summary>path that is exported by the NFS server.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/storage/volumes#nfs
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.NFSVolumeSource#path
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public string Path
        {
            get;
            set;
        }

        /// <summary>server is the hostname or IP address of the NFS server.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/storage/volumes#nfs
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.NFSVolumeSource#server
        /// </remarks>
        [JsiiProperty(name: "server", typeJson: "{\"primitive\":\"string\"}")]
        public string Server
        {
            get;
            set;
        }

        /// <summary>readOnly here will force the NFS export to be mounted with read-only permissions.</summary>
        /// <remarks>
        /// Defaults to false. More info: https://kubernetes.io/docs/concepts/storage/volumes#nfs
        ///
        /// <strong>Default</strong>: false. More info: https://kubernetes.io/docs/concepts/storage/volumes#nfs
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.NFSVolumeSource#readOnly
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "readOnly", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? ReadOnly
        {
            get;
            set;
        }
    }
}
