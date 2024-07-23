using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>Represents a Glusterfs mount that lasts the lifetime of a pod.</summary>
    /// <remarks>
    /// Glusterfs volumes do not support ownership management or SELinux relabeling.
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.GlusterfsPersistentVolumeSource
    /// </remarks>
    [JsiiByValue(fqn: "k8s.GlusterfsPersistentVolumeSource")]
    public class GlusterfsPersistentVolumeSource : K8s.IGlusterfsPersistentVolumeSource
    {
        /// <summary>endpoints is the endpoint name that details Glusterfs topology.</summary>
        /// <remarks>
        /// More info: https://examples.k8s.io/volumes/glusterfs/README.md#create-a-pod
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.GlusterfsPersistentVolumeSource#endpoints
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
        /// <strong>Schema</strong>: io.k8s.api.core.v1.GlusterfsPersistentVolumeSource#path
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public string Path
        {
            get;
            set;
        }

        /// <summary>endpointsNamespace is the namespace that contains Glusterfs endpoint.</summary>
        /// <remarks>
        /// If this field is empty, the EndpointNamespace defaults to the same namespace as the bound PVC. More info: https://examples.k8s.io/volumes/glusterfs/README.md#create-a-pod
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.GlusterfsPersistentVolumeSource#endpointsNamespace
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "endpointsNamespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EndpointsNamespace
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
        /// <strong>Schema</strong>: io.k8s.api.core.v1.GlusterfsPersistentVolumeSource#readOnly
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
