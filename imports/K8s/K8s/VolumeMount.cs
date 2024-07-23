using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>VolumeMount describes a mounting of a Volume within a container.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeMount
    /// </remarks>
    [JsiiByValue(fqn: "k8s.VolumeMount")]
    public class VolumeMount : K8s.IVolumeMount
    {
        /// <summary>Path within the container at which the volume should be mounted.</summary>
        /// <remarks>
        /// Must not contain ':'.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeMount#mountPath
        /// </remarks>
        [JsiiProperty(name: "mountPath", typeJson: "{\"primitive\":\"string\"}")]
        public string MountPath
        {
            get;
            set;
        }

        /// <summary>This must match the Name of a Volume.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeMount#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>mountPropagation determines how mounts are propagated from the host to container and the other way around.</summary>
        /// <remarks>
        /// When not set, MountPropagationNone is used. This field is beta in 1.10. When RecursiveReadOnly is set to IfPossible or to Enabled, MountPropagation must be None or unspecified (which defaults to None).
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeMount#mountPropagation
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mountPropagation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MountPropagation
        {
            get;
            set;
        }

        /// <summary>Mounted read-only if true, read-write otherwise (false or unspecified).</summary>
        /// <remarks>
        /// Defaults to false.
        ///
        /// <strong>Default</strong>: false.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeMount#readOnly
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "readOnly", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? ReadOnly
        {
            get;
            set;
        }

        /// <summary>RecursiveReadOnly specifies whether read-only mounts should be handled recursively.</summary>
        /// <remarks>
        /// If ReadOnly is false, this field has no meaning and must be unspecified.
        ///
        /// If ReadOnly is true, and this field is set to Disabled, the mount is not made recursively read-only.  If this field is set to IfPossible, the mount is made recursively read-only, if it is supported by the container runtime.  If this field is set to Enabled, the mount is made recursively read-only if it is supported by the container runtime, otherwise the pod will not be started and an error will be generated to indicate the reason.
        ///
        /// If this field is set to IfPossible or Enabled, MountPropagation must be set to None (or be unspecified, which defaults to None).
        ///
        /// If this field is not specified, it is treated as an equivalent of Disabled.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeMount#recursiveReadOnly
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "recursiveReadOnly", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RecursiveReadOnly
        {
            get;
            set;
        }

        /// <summary>Path within the volume from which the container's volume should be mounted.</summary>
        /// <remarks>
        /// Defaults to "" (volume's root).
        ///
        /// <strong>Default</strong>: volume's root).
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeMount#subPath
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "subPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubPath
        {
            get;
            set;
        }

        /// <summary>Expanded path within the volume from which the container's volume should be mounted.</summary>
        /// <remarks>
        /// Behaves similarly to SubPath but environment variable references $(VAR_NAME) are expanded using the container's environment. Defaults to "" (volume's root). SubPathExpr and SubPath are mutually exclusive.
        ///
        /// <strong>Default</strong>: volume's root). SubPathExpr and SubPath are mutually exclusive.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeMount#subPathExpr
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "subPathExpr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubPathExpr
        {
            get;
            set;
        }
    }
}
