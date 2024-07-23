using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>Represents a Glusterfs mount that lasts the lifetime of a pod.</summary>
    /// <remarks>
    /// Glusterfs volumes do not support ownership management or SELinux relabeling.
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.GlusterfsVolumeSource
    /// </remarks>
    [JsiiByValue(fqn: "k8s.GlusterfsVolumeSource")]
    public class GlusterfsVolumeSource : K8s.IGlusterfsVolumeSource
    {
        /// <summary>endpoints is the endpoint name that details Glusterfs topology.</summary>
        /// <remarks>
        /// More info: https://examples.k8s.io/volumes/glusterfs/README.md#create-a-pod
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.GlusterfsVolumeSource#endpoints
        /// </remarks>
        [JsiiProperty(name: "endpoints", typeJson: "{\"primitive\":\"string\"}")]
        public string Endpoints
        {
            get;
            set;
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
            get;
            set;
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
            get;
            set;
        }
    }
}
